using i28511.Hattrick.ApiTrick.Enums;

namespace i28511.Hattrick.ApiTrick.MatchDetails;

/// <summary>
/// GetAchievementsRequestModel
/// </summary>
/// <seealso cref="HattrickRequestModel" />
public class GetAchievementsRequestModel : HattrickRequestModel
{
    /// <summary>
    /// Gets or sets the user identifier.
    /// </summary>
    /// <value>
    /// The user identifier.
    /// </value>
    public int? UserId { get; set; }
}