namespace i28511.Hattrick.ApiTrick.MatchDetails;

/// <summary>
/// MatchOfficials
/// </summary>
public class MatchOfficials
{
    /// <summary>
    /// Gets or sets the referee.
    /// </summary>
    /// <value>
    /// The referee.
    /// </value>
    public Referee Referee { get; set; }
    /// <summary>
    /// Gets or sets the referee assistant1.
    /// </summary>
    /// <value>
    /// The referee assistant1.
    /// </value>
    public Referee RefereeAssistant1 { get; set; }
    /// <summary>
    /// Gets or sets the referee assistant2.
    /// </summary>
    /// <value>
    /// The referee assistant2.
    /// </value>
    public Referee RefereeAssistant2 { get; set; }
}