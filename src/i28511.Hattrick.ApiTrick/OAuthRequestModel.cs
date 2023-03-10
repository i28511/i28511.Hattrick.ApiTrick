namespace i28511.Hattrick.ApiTrick;

/// <summary>
/// Base Request struct
/// <para>To be used by all other requests
/// Small instances and commonly short-lived 
/// Tipically embedded in other objects. </para>
/// </summary>
public class OAuthRequestModel
{
    /// <summary>
    /// Gets or sets the access token.
    /// </summary>
    /// <value>
    /// The access token.
    /// </value>
    public string AccessToken { get; set; }
    /// <summary>
    /// Gets or sets the access token secret.
    /// </summary>
    /// <value>
    /// The access token secret.
    /// </value>
    public string AccessTokenSecret { get; set; }

}