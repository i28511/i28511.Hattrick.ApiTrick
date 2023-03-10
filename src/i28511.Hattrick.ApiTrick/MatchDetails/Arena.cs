using i28511.Hattrick.ApiTrick.Enums;

namespace i28511.Hattrick.ApiTrick.MatchDetails;

/// <summary>
/// Arena
/// </summary>
public class Arena
{
    /// <summary>
    /// Gets or sets the arena identifier.
    /// </summary>
    /// <value>
    /// The arena identifier.
    /// </value>
    public int ArenaId { get; set; }
    /// <summary>
    /// Gets or sets the name of the arena.
    /// </summary>
    /// <value>
    /// The name of the arena.
    /// </value>
    public string ArenaName { get; set; }
    /// <summary>
    /// Gets or sets the weather identifier.
    /// </summary>
    /// <value>
    /// The weather identifier.
    /// </value>
    public WeatherType WeatherId { get; set; }
    /// <summary>
    /// Gets or sets the sold total.
    /// </summary>
    /// <value>
    /// The sold total.
    /// </value>
    public int SoldTotal { get; set; }
    /// <summary>
    /// Gets or sets the sold terraces.
    /// </summary>
    /// <value>
    /// The sold terraces.
    /// </value>
    public int SoldTerraces { get; set; }
    /// <summary>
    /// Gets or sets the sold basic.
    /// </summary>
    /// <value>
    /// The sold basic.
    /// </value>
    public int SoldBasic { get; set; }
    /// <summary>
    /// Gets or sets the sold roof.
    /// </summary>
    /// <value>
    /// The sold roof.
    /// </value>
    public int SoldRoof { get; set; }
    /// <summary>
    /// Gets or sets the sold vip.
    /// </summary>
    /// <value>
    /// The sold vip.
    /// </value>
    public int SoldVip { get; set; }
}