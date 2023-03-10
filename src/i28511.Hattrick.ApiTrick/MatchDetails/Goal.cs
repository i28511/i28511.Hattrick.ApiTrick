using i28511.Hattrick.ApiTrick.Enums;

namespace i28511.Hattrick.ApiTrick.MatchDetails;

/// <summary>
/// Goal
/// </summary>
public class Goal
{
    /// <summary>
    /// Gets or sets the scorer player identifier.
    /// </summary>
    /// <value>
    /// The scorer player identifier.
    /// </value>
    public int ScorerPlayerId { get; set; }
    /// <summary>
    /// Gets or sets the name of the scorer player.
    /// </summary>
    /// <value>
    /// The name of the scorer player.
    /// </value>
    public string ScorerPlayerName { get; set; }
    /// <summary>
    /// Gets or sets the scorer team identifier.
    /// </summary>
    /// <value>
    /// The scorer team identifier.
    /// </value>
    public int ScorerTeamId { get; set; }
    /// <summary>
    /// Gets or sets the scorer home goals.
    /// </summary>
    /// <value>
    /// The scorer home goals.
    /// </value>
    public int ScorerHomeGoals { get; set; }
    /// <summary>
    /// Gets or sets the scorer away goals.
    /// </summary>
    /// <value>
    /// The scorer away goals.
    /// </value>
    public int ScorerAwayGoals { get; set; }
    /// <summary>
    /// Gets or sets the scorer minute.
    /// </summary>
    /// <value>
    /// The scorer minute.
    /// </value>
    public int ScorerMinute { get; set; }
    /// <summary>
    /// Gets or sets the match part.
    /// </summary>
    /// <value>
    /// The match part.
    /// </value>
    public MatchPart MatchPart { get; set; }
}