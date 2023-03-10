using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl.MatchDetails;

/// <summary>
/// GoalXml
/// </summary>
public class GoalXml
{
    /// <summary>
    /// Gets or sets the scorer player identifier.
    /// </summary>
    /// <value>
    /// The scorer player identifier.
    /// </value>
    [XmlElement("ScorerPlayerID")]
    public int ScorerPlayerId { get; set; }
    /// <summary>
    /// Gets or sets the name of the scorer player.
    /// </summary>
    /// <value>
    /// The name of the scorer player.
    /// </value>
    [XmlElement]
    public string ScorerPlayerName { get; set; }
    /// <summary>
    /// Gets or sets the scorer team identifier.
    /// </summary>
    /// <value>
    /// The scorer team identifier.
    /// </value>
    [XmlElement("ScorerTeamID")]
    public int ScorerTeamId { get; set; }
    /// <summary>
    /// Gets or sets the scorer home goals.
    /// </summary>
    /// <value>
    /// The scorer home goals.
    /// </value>
    [XmlElement]
    public int ScorerHomeGoals { get; set; }
    /// <summary>
    /// Gets or sets the scorer away goals.
    /// </summary>
    /// <value>
    /// The scorer away goals.
    /// </value>
    [XmlElement]
    public int ScorerAwayGoals { get; set; }
    /// <summary>
    /// Gets or sets the scorer minute.
    /// </summary>
    /// <value>
    /// The scorer minute.
    /// </value>
    [XmlElement]
    public int ScorerMinute { get; set; }
    /// <summary>
    /// Gets or sets the match part.
    /// </summary>
    /// <value>
    /// The match part.
    /// </value>
    [XmlElement]
    public int MatchPart { get; set; }
}