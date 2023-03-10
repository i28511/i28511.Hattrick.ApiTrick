using i28511.Hattrick.ApiTrick.Enums;

namespace i28511.Hattrick.ApiTrick.MatchDetails;

/// <summary>
/// GetMatchDetailsRequestModel
/// </summary>
/// <seealso cref="HattrickRequestModel" />
public class GetMatchDetailsRequestModel : HattrickRequestModel
{
    /// <summary>
    /// Gets or sets a value indicating whether [match events].
    /// </summary>
    /// <value>
    ///   <c>true</c> if [match events]; otherwise, <c>false</c>.
    /// </value>
    public bool MatchEvents { get; set; } = false;
    /// <summary>
    /// Gets or sets the match identifier.
    /// </summary>
    /// <value>
    /// The match identifier.
    /// </value>
    public int MatchId { get; set; }
    /// <summary>
    /// Gets or sets the source system.
    /// </summary>
    /// <value>
    /// The source system.
    /// </value>
    public SourceSystem SourceSystem { get; set; }
}