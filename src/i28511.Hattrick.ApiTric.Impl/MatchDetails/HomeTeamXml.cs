using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl.MatchDetails;

/// <summary>
/// TeamXml
/// </summary>
public class HomeTeamXml
{
    /// <summary>
    /// Gets or sets the team identifier.
    /// </summary>
    /// <value>
    /// The team identifier.
    /// </value>
    [XmlElement("HomeTeamID")]
    public int HomeTeamId { get; set; }
    /// <summary>
    /// Gets or sets the name of the team.
    /// </summary>
    /// <value>
    /// The name of the team.
    /// </value>
    [XmlElement]
    public string HomeTeamName { get; set; }
    /// <summary>
    /// Gets or sets the dress URI.
    /// </summary>
    /// <value>
    /// The dress URI.
    /// </value>
    [XmlElement("DressURI")]
    public string DressUri { get; set; }
    /// <summary>
    /// Gets or sets the formation.
    /// </summary>
    /// <value>
    /// The formation.
    /// </value>
    [XmlElement]
    public string Formation { get; set; }
    /// <summary>
    /// Gets or sets the goals.
    /// </summary>
    /// <value>
    /// The goals.
    /// </value>
    [XmlElement]
    public int HomeGoals { get; set; }
    /// <summary>
    /// Gets or sets the type of the tactic.
    /// </summary>
    /// <value>
    /// The type of the tactic.
    /// </value>
    [XmlElement]
    public int TacticType { get; set; }
    /// <summary>
    /// Gets or sets the tactic skill.
    /// </summary>
    /// <value>
    /// The tactic skill.
    /// </value>
    [XmlElement]
    public int TacticSkill { get; set; }
    /// <summary>
    /// Gets or sets the rating midfield.
    /// </summary>
    /// <value>
    /// The rating midfield.
    /// </value>
    [XmlElement]
    public int RatingMidfield { get; set; }
    /// <summary>
    /// Gets or sets the rating right definition.
    /// </summary>
    /// <value>
    /// The rating right definition.
    /// </value>
    [XmlElement]
    public int RatingRightDef { get; set; }
    /// <summary>
    /// Gets or sets the rating mid definition.
    /// </summary>
    /// <value>
    /// The rating mid definition.
    /// </value>
    [XmlElement]
    public int RatingMidDef { get; set; }
    /// <summary>
    /// Gets or sets the rating left definition.
    /// </summary>
    /// <value>
    /// The rating left definition.
    /// </value>
    [XmlElement]
    public int RatingLeftDef { get; set; }
    /// <summary>
    /// Gets or sets the rating right att.
    /// </summary>
    /// <value>
    /// The rating right att.
    /// </value>
    [XmlElement]
    public int RatingRightAtt { get; set; }
    /// <summary>
    /// Gets or sets the rating mid att.
    /// </summary>
    /// <value>
    /// The rating mid att.
    /// </value>
    [XmlElement]
    public int RatingMidAtt { get; set; }
    /// <summary>
    /// Gets or sets the rating left att.
    /// </summary>
    /// <value>
    /// The rating left att.
    /// </value>
    [XmlElement]
    public int RatingLeftAtt { get; set; }
    /// <summary>
    /// Gets or sets the team attitude.
    /// </summary>
    /// <value>
    /// The team attitude.
    /// </value>
    [XmlElement]
    public int TeamAttitude { get; set; }
    /// <summary>
    /// Gets or sets the rating indirect set pieces definition.
    /// </summary>
    /// <value>
    /// The rating indirect set pieces definition.
    /// </value>
    [XmlElement]
    public int RatingIndirectSetPiecesDef { get; set; }
    /// <summary>
    /// Gets or sets the rating indirect set pieces att.
    /// </summary>
    /// <value>
    /// The rating indirect set pieces att.
    /// </value>
    [XmlElement]
    public int RatingIndirectSetPiecesAtt { get; set; }
    /// <summary>
    /// Gets or sets the number of chances left.
    /// </summary>
    /// <value>
    /// The number of chances left.
    /// </value>
    [XmlElement]
    public int NrOfChancesLeft { get; set; }
    /// <summary>
    /// Gets or sets the number of chances center.
    /// </summary>
    /// <value>
    /// The number of chances center.
    /// </value>
    [XmlElement]
    public int NrOfChancesCenter { get; set; }
    /// <summary>
    /// Gets or sets the number of chances right.
    /// </summary>
    /// <value>
    /// The number of chances right.
    /// </value>
    [XmlElement]
    public int NrOfChancesRight { get; set; }
    /// <summary>
    /// Gets or sets the number of chances special events.
    /// </summary>
    /// <value>
    /// The number of chances special events.
    /// </value>
    [XmlElement]
    public int NrOfChancesSpecialEvents { get; set; }
    /// <summary>
    /// Gets or sets the number of chances other.
    /// </summary>
    /// <value>
    /// The number of chances other.
    /// </value>
    [XmlElement]
    public int NrOfChancesOther { get; set; }
}