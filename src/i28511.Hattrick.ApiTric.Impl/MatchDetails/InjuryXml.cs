using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl.MatchDetails;

/// <summary>
/// InjuryXml
/// </summary>
public class InjuryXml
{
    /// <summary>
    /// Gets or sets the injury player identifier.
    /// </summary>
    /// <value>
    /// The injury player identifier.
    /// </value>
    [XmlElement("InjuryPlayerID")]
    public int InjuryPlayerId { get; set; }
    /// <summary>
    /// Gets or sets the name of the injury player.
    /// </summary>
    /// <value>
    /// The name of the injury player.
    /// </value>
    [XmlElement]
    public string InjuryPlayerName { get; set; }
    /// <summary>
    /// Gets or sets the injury team identifier.
    /// </summary>
    /// <value>
    /// The injury team identifier.
    /// </value>
    [XmlElement("InjuryTeamID")]
    public int InjuryTeamId { get; set; }
    /// <summary>
    /// Gets or sets the type of the injury.
    /// </summary>
    /// <value>
    /// The type of the injury.
    /// </value>
    [XmlElement]
    public int InjuryType { get; set; }
    /// <summary>
    /// Gets or sets the injury minute.
    /// </summary>
    /// <value>
    /// The injury minute.
    /// </value>
    [XmlElement]
    public int InjuryMinute { get; set; }
    /// <summary>
    /// Gets or sets the match part.
    /// </summary>
    /// <value>
    /// The match part.
    /// </value>
    [XmlElement]
    public int MatchPart { get; set; }
}