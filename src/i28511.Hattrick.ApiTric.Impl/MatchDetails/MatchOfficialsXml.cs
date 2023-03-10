using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl.MatchDetails;

/// <summary>
/// MatchOfficialsXml
/// </summary>
public class MatchOfficialsXml
{
    /// <summary>
    /// Gets or sets the referee.
    /// </summary>
    /// <value>
    /// The referee.
    /// </value>
    [XmlElement]
    public RefereeXml Referee { get; set; }
    /// <summary>
    /// Gets or sets the referee assistant1.
    /// </summary>
    /// <value>
    /// The referee assistant1.
    /// </value>
    [XmlElement]
    public RefereeXml RefereeAssistant1 { get; set; }
    /// <summary>
    /// Gets or sets the referee assistant2.
    /// </summary>
    /// <value>
    /// The referee assistant2.
    /// </value>
    [XmlElement]
    public RefereeXml RefereeAssistant2 { get; set; }
}