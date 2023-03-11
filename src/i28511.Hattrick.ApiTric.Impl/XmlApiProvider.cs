using System.Xml.Serialization;
using i28511.Hattrick.ApiTrick.Achievements;
using i28511.Hattrick.ApiTrick.Impl.Achievements;
using i28511.Hattrick.ApiTrick.Impl.Config;
using i28511.Hattrick.ApiTrick.Impl.MatchDetails;
using i28511.Hattrick.ApiTrick.MatchDetails;
using OAuth;

namespace i28511.Hattrick.ApiTrick.Impl;

public class XmlApiProvider : IXmlApiProvider
{
    private readonly HttpClient _httpClient;
    private readonly OAuthOptions _options;
    private readonly XmlApiConfig _config;

    internal XmlApiProvider(OAuthOptions options)
    {
        _httpClient = new HttpClient();
        _options = options;

        _config = ConfigurationHelper.GetXmlConfig();
    }

    public async Task<Match> GetMatchDetailsAsync(GetMatchDetailsRequestModel request, CancellationToken ct)
    {
        string version;
        const string file = "MatchDetails";
        if (!string.IsNullOrWhiteSpace(request.Version))
        {
            CheckIfVersionExistsOrThrowError(file, request.Version);
            version = request.Version;
        }

        else
        {
            version = GetLastVersionOrThrowError(file);
        }

        var uri = GetFullFilePath(file);

        var parameters = System.Web.HttpUtility.ParseQueryString(uri.Query);

        parameters.Add(nameof(request.Version).ToLowerFirstChar(), version);
        parameters.Add(nameof(request.MatchEvents).ToLowerFirstChar(), request.MatchEvents.ToString());
        parameters.Add(nameof(request.MatchId).ToLowerFirstChar(), request.MatchId.ToString());
        parameters.Add(nameof(request.SourceSystem).ToLowerFirstChar(), request.SourceSystem.ToString());

        uri.Query = parameters.ToString() ?? throw new InvalidOperationException();

        var oAuthRequest = OAuthRequest.ForProtectedResource(
            "GET",
            _options.ConsumerKey,
            _options.ConsumerSecret,
            request.AccessToken,
            request.AccessTokenSecret);


        oAuthRequest.RequestUrl = uri.Uri.AbsoluteUri;
        var auth = oAuthRequest.GetAuthorizationQuery();

        parameters.Add(System.Web.HttpUtility.ParseQueryString(auth));
        uri.Query = parameters.ToString() ?? throw new InvalidOperationException();


        var response = await GetDataAsync<HattrickData>(uri.Uri.AbsoluteUri, ct);

        if (response.Match is not null)
            return response.Match.ToMatch();
        throw new InvalidOperationException("Match XML file not found.");

    }

    public async Task<IReadOnlyCollection<Achievement>> GetAchievementsAsync(GetAchievementsRequestModel request, CancellationToken ct)
    {
        string version;
        const string file = "Achievements";
        if (!string.IsNullOrWhiteSpace(request.Version))
        {
            CheckIfVersionExistsOrThrowError(file, request.Version);
            version = request.Version;
        }

        else
        {
            version = GetLastVersionOrThrowError(file);
        }

        var uri = GetFullFilePath(file);

        var parameters = System.Web.HttpUtility.ParseQueryString(uri.Query);

        parameters.Add(nameof(request.Version).ToLowerFirstChar(), version);

        if(request.UserId is not null)
            parameters.Add(nameof(request.UserId).ToLowerFirstChar(), request.UserId.ToString());

        uri.Query = parameters.ToString() ?? throw new InvalidOperationException();

        var oAuthRequest = OAuthRequest.ForProtectedResource(
            "GET",
            _options.ConsumerKey,
            _options.ConsumerSecret,
            request.AccessToken,
            request.AccessTokenSecret);


        oAuthRequest.RequestUrl = uri.Uri.AbsoluteUri;
        var auth = oAuthRequest.GetAuthorizationQuery();

        parameters.Add(System.Web.HttpUtility.ParseQueryString(auth));
        uri.Query = parameters.ToString() ?? throw new InvalidOperationException();


        var response = await GetDataAsync<HattrickData>(uri.Uri.AbsoluteUri, ct);

        if (response.AchievementList.Achievement.Length > 0)
           return response.AchievementList.Achievement.Select(a=>a.ToAchievement()).ToArray();
        throw new InvalidOperationException("Match XML file not found.");
    }

    private async Task<T> GetDataAsync<T>(string endpoint, CancellationToken ct)
    {
        var response = await _httpClient.GetAsync(endpoint, ct);
        response.EnsureSuccessStatusCode();
        
        await using var stream = await response.Content.ReadAsStreamAsync(ct);

        var serializer = new XmlSerializer(typeof(T));
        var data = (T)serializer.Deserialize(stream);

        return data;
    }

    private void GetFilePathIfExistsOrThrowError(string fileToCheck, out XmlFileConfig file)
    {
        var dic = _config.XmlFiles;

        if (!dic.TryGetValue(fileToCheck, out file))
        {
            throw new ArgumentException($"The file '{fileToCheck}' does not exist in the configuration.");
        }
    }


    private void CheckIfVersionExistsOrThrowError(string fileToCheck, string version)
    {

        GetFilePathIfExistsOrThrowError(fileToCheck, out var file);
        
        if (file.Versions == null || file.Versions.Count == 0 || !file.Versions.Contains(version))
        {
            throw new ArgumentException($"The version '{version}' does not exist for file '{fileToCheck}' in the configuration.");
        }
    }

    private string GetLastVersionOrThrowError(string fileToCheck)
    {

        GetFilePathIfExistsOrThrowError(fileToCheck, out var file);

        if (file.Versions == null || file.Versions.Count == 0)
        {
            throw new NotImplementedException($"The file '{fileToCheck}' does not exist in the configuration.");
        }

        return file.Versions.First();
    }

    private UriBuilder GetFullFilePath(string fileToCheck)
    {
        if (string.IsNullOrWhiteSpace(_config.ProtectedResourcesPath))
        {
            throw new InvalidOperationException("Protected resources path not found.");
        }

        var builder = new UriBuilder(_config.ProtectedResourcesPath);
            
        var parameters = System.Web.HttpUtility.ParseQueryString(builder.Query);
        GetFilePathIfExistsOrThrowError(fileToCheck, out var file);
        parameters.Add("file", file.File);
        builder.Query = parameters.ToString() ?? throw new InvalidOperationException();

        return builder;
    }
}



