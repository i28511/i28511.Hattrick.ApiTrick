
using i28511.Hattrick.ApiTrick.Achievements;
using i28511.Hattrick.ApiTrick.MatchDetails;

namespace i28511.Hattrick.ApiTrick
{
    public interface IXmlApiProvider
    {
        public Task<Match> GetMatchDetailsAsync(GetMatchDetailsRequestModel request, CancellationToken ct);
        public Task<IReadOnlyCollection<Achievement>> GetAchievementsAsync(GetAchievementsRequestModel request, CancellationToken ct);


    }
}
