using i28511.Hattrick.ApiTrick.Enums;
using MatchType = i28511.Hattrick.ApiTrick.Enums.MatchType;

namespace i28511.Hattrick.ApiTrick.MatchDetails;

/// <summary>
/// Match
/// </summary>
public class Match
{
    /// <summary>
    /// Gets or sets the match identifier.
    /// </summary>
    /// <value>
    /// The match identifier.
    /// </value>
    public int MatchId { get; set; }
    /// <summary>
    /// Gets or sets the type of the match.
    /// </summary>
    /// <value>
    /// The type of the match.
    /// </value>
    public MatchType MatchType { get; set; }
    /// <summary>
    /// Gets or sets the match context identifier.
    /// </summary>
    /// <value>
    /// The match context identifier.
    /// </value>
    public int MatchContextId { get; set; }
    /// <summary>
    /// Gets or sets the match rule identifier.
    /// </summary>
    /// <value>
    /// The match rule identifier.
    /// </value>
    public MatchRuleType MatchRuleId { get; set; }
    /// <summary>
    /// Gets or sets the cup level.
    /// </summary>
    /// <value>
    /// The cup level.
    /// </value>
    public int CupLevel { get; set; }
    /// <summary>
    /// Gets or sets the index of the cup level.
    /// </summary>
    /// <value>
    /// The index of the cup level.
    /// </value>
    public int CupLevelIndex { get; set; }
    /// <summary>
    /// Gets or sets the match date.
    /// </summary>
    /// <value>
    /// The match date.
    /// </value>
    public DateTime MatchDate { get; set; }
    /// <summary>
    /// Gets or sets the finished date.
    /// </summary>
    /// <value>
    /// The finished date.
    /// </value>
    public DateTime? FinishedDate { get; set; }
    /// <summary>
    /// Gets or sets the added minutes.
    /// </summary>
    /// <value>
    /// The added minutes.
    /// </value>
    public int? AddedMinutes { get; set; }
    /// <summary>
    /// Gets or sets the home team.
    /// </summary>
    /// <value>
    /// The home team.
    /// </value>
    public Team HomeTeam { get; set; }
    /// <summary>
    /// Gets or sets the away team.
    /// </summary>
    /// <value>
    /// The away team.
    /// </value>
    public Team AwayTeam { get; set; }
    /// <summary>
    /// Gets or sets the arena.
    /// </summary>
    /// <value>
    /// The arena.
    /// </value>
    public Arena Arena { get; set; }
    /// <summary>
    /// Gets or sets the match officials.
    /// </summary>
    /// <value>
    /// The match officials.
    /// </value>
    public MatchOfficials MatchOfficials { get; set; }
    /// <summary>
    /// Gets or sets the scorers.
    /// </summary>
    /// <value>
    /// The scorers.
    /// </value>
    public IReadOnlyCollection<Goal> Scorers { get; set; }
    /// <summary>
    /// Gets or sets the bookings.
    /// </summary>
    /// <value>
    /// The bookings.
    /// </value>
    public IReadOnlyCollection<Booking> Bookings { get; set; }
    /// <summary>
    /// Gets or sets the injuries.
    /// </summary>
    /// <value>
    /// The injuries.
    /// </value>
    public IReadOnlyCollection<Injury> Injuries { get; set; }
    /// <summary>
    /// Gets or sets the possession first half home.
    /// </summary>
    /// <value>
    /// The possession first half home.
    /// </value>
    public int? PossessionFirstHalfHome { get; set; }
    /// <summary>
    /// Gets or sets the possession first half away.
    /// </summary>
    /// <value>
    /// The possession first half away.
    /// </value>
    public int? PossessionFirstHalfAway { get; set; }
    /// <summary>
    /// Gets or sets the possession second half home.
    /// </summary>
    /// <value>
    /// The possession second half home.
    /// </value>
    public int? PossessionSecondHalfHome { get; set; }
    /// <summary>
    /// Gets or sets the possession second half away.
    /// </summary>
    /// <value>
    /// The possession second half away.
    /// </value>
    public int? PossessionSecondHalfAway { get; set; }

}