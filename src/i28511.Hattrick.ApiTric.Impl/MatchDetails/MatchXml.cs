using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl.MatchDetails;

/// <summary>
/// MatchXml
/// </summary>
public class MatchXml
{

    /// <summary>
    /// Gets or sets the match identifier.
    /// </summary>
    /// <value>
    /// The match identifier.
    /// </value>
    [XmlElement("MatchID")]
    public int MatchId { get; set; }
    /// <summary>
    /// Gets or sets the type of the match.
    /// </summary>
    /// <value>
    /// The type of the match.
    /// </value>
    [XmlElement]
    public int MatchType { get; set; }
    /// <summary>
    /// Gets or sets the match context identifier.
    /// </summary>
    /// <value>
    /// The match context identifier.
    /// </value>
    [XmlElement]
    public int MatchContextId { get; set; }
    /// <summary>
    /// Gets or sets the match rule identifier.
    /// </summary>
    /// <value>
    /// The match rule identifier.
    /// </value>
    [XmlElement]
    public int MatchRuleId { get; set; }
    /// <summary>
    /// Gets or sets the cup level.
    /// </summary>
    /// <value>
    /// The cup level.
    /// </value>
    [XmlElement]
    public int CupLevel { get; set; }
    /// <summary>
    /// Gets or sets the index of the cup level.
    /// </summary>
    /// <value>
    /// The index of the cup level.
    /// </value>
    [XmlElement]
    public int CupLevelIndex { get; set; }
    /// <summary>
    /// Gets or sets the match date.
    /// </summary>
    /// <value>
    /// The match date.
    /// </value>
    [XmlElement]
    public string MatchDate { get; set; }
    /// <summary>
    /// Gets or sets the finished date.
    /// </summary>
    /// <value>
    /// The finished date.
    /// </value>
    [XmlElement]
    public string FinishedDate { get; set; }
    /// <summary>
    /// Gets or sets the added minutes.
    /// </summary>
    /// <value>
    /// The added minutes.
    /// </value>
    [XmlElement]
    public int? AddedMinutes { get; set; }
    /// <summary>
    /// Gets or sets the home team.
    /// </summary>
    /// <value>
    /// The home team.
    /// </value>
    [XmlElement]
    public HomeTeamXml HomeTeam { get; set; }
    /// <summary>
    /// Gets or sets the away team.
    /// </summary>
    /// <value>
    /// The away team.
    /// </value>
    [XmlElement]
    public AwayTeamXml AwayTeam { get; set; }
    /// <summary>
    /// Gets or sets the arena.
    /// </summary>
    /// <value>
    /// The arena.
    /// </value>
    [XmlElement]
    public ArenaXml Arena { get; set; }
    /// <summary>
    /// Gets or sets the match officials.
    /// </summary>
    /// <value>
    /// The match officials.
    /// </value>
    [XmlElement]
    public MatchOfficialsXml MatchOfficials { get; set; }
    /// <summary>
    /// Gets or sets the scorers.
    /// </summary>
    /// <value>
    /// The scorers.
    /// </value>
    [XmlArray]
    [XmlArrayItem("Goal", IsNullable = false)]
    public GoalXml[] Scorers { get; set; }
    /// <summary>
    /// Gets or sets the bookings.
    /// </summary>
    /// <value>
    /// The bookings.
    /// </value>
    [XmlArray]
    [XmlArrayItem("Booking", IsNullable = false)]
    public BookingXml[] Bookings { get; set; }
    /// <summary>
    /// Gets or sets the injuries.
    /// </summary>
    /// <value>
    /// The injuries.
    /// </value>
    [XmlArray]
    [XmlArrayItem("Injury", IsNullable = false)]
    public InjuryXml[] Injuries { get; set; }
    /// <summary>
    /// Gets or sets the possession first half home.
    /// </summary>
    /// <value>
    /// The possession first half home.
    /// </value>
    [XmlElement]
    public int? PossessionFirstHalfHome { get; set; }
    /// <summary>
    /// Gets or sets the possession first half away.
    /// </summary>
    /// <value>
    /// The possession first half away.
    /// </value>
    [XmlElement]
    public int? PossessionFirstHalfAway { get; set; }
    /// <summary>
    /// Gets or sets the possession second half home.
    /// </summary>
    /// <value>
    /// The possession second half home.
    /// </value>
    [XmlElement]
    public int? PossessionSecondHalfHome { get; set; }
    /// <summary>
    /// Gets or sets the possession second half away.
    /// </summary>
    /// <value>
    /// The possession second half away.
    /// </value>
    [XmlElement]
    public int? PossessionSecondHalfAway { get; set; }
}