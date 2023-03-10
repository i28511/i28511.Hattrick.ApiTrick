namespace i28511.Hattrick.ApiTrick.MatchDetails;

/// <summary>
/// Referee
/// </summary>
public class Referee
{
    /// <summary>
    /// Gets or sets the referee identifier.
    /// </summary>
    /// <value>
    /// The referee identifier.
    /// </value>
    public int RefereeId { get; set; }
    /// <summary>
    /// Gets or sets the name of the referee.
    /// </summary>
    /// <value>
    /// The name of the referee.
    /// </value>
    public string RefereeName { get; set; }
    /// <summary>
    /// Gets or sets the referee country identifier.
    /// </summary>
    /// <value>
    /// The referee country identifier.
    /// </value>
    public int RefereeCountryId { get; set; }
    /// <summary>
    /// Gets or sets the name of the referee country.
    /// </summary>
    /// <value>
    /// The name of the referee country.
    /// </value>
    public string RefereeCountryName { get; set; }
    /// <summary>
    /// Gets or sets the referee team identifier.
    /// </summary>
    /// <value>
    /// The referee team identifier.
    /// </value>
    public int RefereeTeamId { get; set; }
    /// <summary>
    /// Gets or sets the referee teamname.
    /// </summary>
    /// <value>
    /// The referee teamname.
    /// </value>
    public string RefereeTeamname { get; set; }
}