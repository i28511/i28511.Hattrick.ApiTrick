using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl.MatchDetails;

/// <summary>
/// BookingXml
/// </summary>
public class BookingXml
{
    /// <summary>
    /// Gets or sets the booking player identifier.
    /// </summary>
    /// <value>
    /// The booking player identifier.
    /// </value>
    [XmlElement("BookingPlayerID")]
    public int BookingPlayerId { get; set; }
    /// <summary>
    /// Gets or sets the name of the booking player.
    /// </summary>
    /// <value>
    /// The name of the booking player.
    /// </value>
    [XmlElement]
    public string BookingPlayerName { get; set; }
    /// <summary>
    /// Gets or sets the booking team identifier.
    /// </summary>
    /// <value>
    /// The booking team identifier.
    /// </value>
    [XmlElement("BookingTeamID")]
    public int BookingTeamId { get; set; }
    /// <summary>
    /// Gets or sets the type of the booking.
    /// </summary>
    /// <value>
    /// The type of the booking.
    /// </value>
    [XmlElement]
    public int BookingType { get; set; }
    /// <summary>
    /// Gets or sets the booking minute.
    /// </summary>
    /// <value>
    /// The booking minute.
    /// </value>
    [XmlElement]
    public int BookingMinute { get; set; }
    /// <summary>
    /// Gets or sets the match part.
    /// </summary>
    /// <value>
    /// The match part.
    /// </value>
    [XmlElement]
    public int MatchPart { get; set; }
}