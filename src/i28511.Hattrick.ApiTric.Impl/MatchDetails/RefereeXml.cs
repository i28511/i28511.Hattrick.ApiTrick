using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl.MatchDetails;

/// <summary>
/// RefereeXml
/// </summary>
public class RefereeXml
{
    /// <summary>
    /// Gets or sets the referee identifier.
    /// </summary>
    /// <value>
    /// The referee identifier.
    /// </value>
    [XmlElement]
    public int RefereeId { get; set; }
    /// <summary>
    /// Gets or sets the name of the referee.
    /// </summary>
    /// <value>
    /// The name of the referee.
    /// </value>
    [XmlElement]
    public string RefereeName { get; set; }
    /// <summary>
    /// Gets or sets the referee country identifier.
    /// </summary>
    /// <value>
    /// The referee country identifier.
    /// </value>
    [XmlElement]
    public int RefereeCountryId { get; set; }
    /// <summary>
    /// Gets or sets the name of the referee country.
    /// </summary>
    /// <value>
    /// The name of the referee country.
    /// </value>
    [XmlElement]
    public string RefereeCountryName { get; set; }
    /// <summary>
    /// Gets or sets the referee team identifier.
    /// </summary>
    /// <value>
    /// The referee team identifier.
    /// </value>
    [XmlElement]
    public int RefereeTeamId { get; set; }
    /// <summary>
    /// Gets or sets the referee teamname.
    /// </summary>
    /// <value>
    /// The referee teamname.
    /// </value>
    [XmlElement("RefereeTeamname")]
    public string RefereeTeamName { get; set; }
}