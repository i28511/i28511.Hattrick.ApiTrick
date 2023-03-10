using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl.MatchDetails;

/// <summary>
/// ArenaXml
/// </summary>
public class ArenaXml
{
    /// <summary>
    /// Gets or sets the arena identifier.
    /// </summary>
    /// <value>
    /// The arena identifier.
    /// </value>
    [XmlElement("ArenaID")]
    public int ArenaId { get; set; }
    /// <summary>
    /// Gets or sets the name of the arena.
    /// </summary>
    /// <value>
    /// The name of the arena.
    /// </value>
    [XmlElement]
    public string ArenaName { get; set; }
    /// <summary>
    /// Gets or sets the weather identifier.
    /// </summary>
    /// <value>
    /// The weather identifier.
    /// </value>
    [XmlElement]
    public int WeatherId { get; set; }
    /// <summary>
    /// Gets or sets the sold total.
    /// </summary>
    /// <value>
    /// The sold total.
    /// </value>
    [XmlElement]
    public int SoldTotal { get; set; }
    /// <summary>
    /// Gets or sets the sold terraces.
    /// </summary>
    /// <value>
    /// The sold terraces.
    /// </value>
    [XmlElement]
    public int SoldTerraces { get; set; }
    /// <summary>
    /// Gets or sets the sold basic.
    /// </summary>
    /// <value>
    /// The sold basic.
    /// </value>
    [XmlElement]
    public int SoldBasic { get; set; }
    /// <summary>
    /// Gets or sets the sold roof.
    /// </summary>
    /// <value>
    /// The sold roof.
    /// </value>
    [XmlElement]
    public int SoldRoof { get; set; }
    /// <summary>
    /// Gets or sets the sold vip.
    /// </summary>
    /// <value>
    /// The sold vip.
    /// </value>
    [XmlElement("SoldVIP")]
    public int SoldVip { get; set; }
}