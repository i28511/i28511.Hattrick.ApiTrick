using i28511.Hattrick.ApiTrick.Enums;

namespace i28511.Hattrick.ApiTrick.MatchDetails;

/// <summary>
/// Injury
/// </summary>
public class Injury
{
    /// <summary>
    /// Gets or sets the injury player identifier.
    /// </summary>
    /// <value>
    /// The injury player identifier.
    /// </value>
    public int InjuryPlayerId { get; set; }
    /// <summary>
    /// Gets or sets the name of the injury player.
    /// </summary>
    /// <value>
    /// The name of the injury player.
    /// </value>
    public string InjuryPlayerName { get; set; }
    /// <summary>
    /// Gets or sets the injury team identifier.
    /// </summary>
    /// <value>
    /// The injury team identifier.
    /// </value>
    public int InjuryTeamId { get; set; }
    /// <summary>
    /// Gets or sets the type of the injury.
    /// </summary>
    /// <value>
    /// The type of the injury.
    /// </value>
    public InjuryType InjuryType { get; set; }
    /// <summary>
    /// Gets or sets the injury minute.
    /// </summary>
    /// <value>
    /// The injury minute.
    /// </value>
    public int InjuryMinute { get; set; }
    /// <summary>
    /// Gets or sets the match part.
    /// </summary>
    /// <value>
    /// The match part.
    /// </value>
    public MatchPart MatchPart { get; set; }
}