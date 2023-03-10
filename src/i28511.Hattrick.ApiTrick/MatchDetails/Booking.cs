using i28511.Hattrick.ApiTrick.Enums;

namespace i28511.Hattrick.ApiTrick.MatchDetails;

/// <summary>
/// Booking
/// </summary>
public class Booking
{
    /// <summary>
    /// Gets or sets the booking player identifier.
    /// </summary>
    /// <value>
    /// The booking player identifier.
    /// </value>
    public int BookingPlayerId { get; set; }
    /// <summary>
    /// Gets or sets the name of the booking player.
    /// </summary>
    /// <value>
    /// The name of the booking player.
    /// </value>
    public string BookingPlayerName { get; set; }
    /// <summary>
    /// Gets or sets the booking team identifier.
    /// </summary>
    /// <value>
    /// The booking team identifier.
    /// </value>
    public int BookingTeamId { get; set; }
    /// <summary>
    /// Gets or sets the type of the booking.
    /// </summary>
    /// <value>
    /// The type of the booking.
    /// </value>
    public BookingType BookingType { get; set; }
    /// <summary>
    /// Gets or sets the booking minute.
    /// </summary>
    /// <value>
    /// The booking minute.
    /// </value>
    public int BookingMinute { get; set; }
    /// <summary>
    /// Gets or sets the match part.
    /// </summary>
    /// <value>
    /// The match part.
    /// </value>
    public MatchPart MatchPart { get; set; }
}