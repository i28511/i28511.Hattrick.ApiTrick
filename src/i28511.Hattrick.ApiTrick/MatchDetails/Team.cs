using i28511.Hattrick.ApiTrick.Enums;
using System;

namespace i28511.Hattrick.ApiTrick.MatchDetails;

/// <summary>
/// Team
/// </summary>
public class Team
{
    /// <summary>
    /// Gets or sets the team identifier.
    /// </summary>
    /// <value>
    /// The team identifier.
    /// </value>
    public int TeamId { get; set; }
    /// <summary>
    /// Gets or sets the name of the team.
    /// </summary>
    /// <value>
    /// The name of the team.
    /// </value>
    public string TeamName { get; set; }
    /// <summary>
    /// Gets or sets the dress URI.
    /// </summary>
    /// <value>
    /// The dress URI.
    /// </value>
    public Uri DressUri { get; set; }
    /// <summary>
    /// Gets or sets the formation.
    /// </summary>
    /// <value>
    /// The formation.
    /// </value>
    public string Formation { get; set; }
    /// <summary>
    /// Gets or sets the goals.
    /// </summary>
    /// <value>
    /// The goals.
    /// </value>
    public int Goals { get; set; } = 0;
    /// <summary>
    /// Gets or sets the type of the tactic.
    /// </summary>
    /// <value>
    /// The type of the tactic.
    /// </value>
    public MatchTacticType TacticType { get; set; }
    /// <summary>
    /// Gets or sets the tactic skill.
    /// </summary>
    /// <value>
    /// The tactic skill.
    /// </value>
    public SkillLevel TacticSkill { get; set; }
    /// <summary>
    /// Gets or sets the rating midfield.
    /// </summary>
    /// <value>
    /// The rating midfield.
    /// </value>
    public MatchRating RatingMidfield { get; set; }
    /// <summary>
    /// Gets or sets the rating right definition.
    /// </summary>
    /// <value>
    /// The rating right definition.
    /// </value>
    public MatchRating RatingRightDef { get; set; }
    /// <summary>
    /// Gets or sets the rating mid definition.
    /// </summary>
    /// <value>
    /// The rating mid definition.
    /// </value>
    public MatchRating RatingMidDef { get; set; }
    /// <summary>
    /// Gets or sets the rating left definition.
    /// </summary>
    /// <value>
    /// The rating left definition.
    /// </value>
    public MatchRating RatingLeftDef { get; set; }
    /// <summary>
    /// Gets or sets the rating right att.
    /// </summary>
    /// <value>
    /// The rating right att.
    /// </value>
    public MatchRating RatingRightAtt { get; set; }
    /// <summary>
    /// Gets or sets the rating mid att.
    /// </summary>
    /// <value>
    /// The rating mid att.
    /// </value>
    public MatchRating RatingMidAtt { get; set; }
    /// <summary>
    /// Gets or sets the rating left att.
    /// </summary>
    /// <value>
    /// The rating left att.
    /// </value>
    public MatchRating RatingLeftAtt { get; set; }
    /// <summary>
    /// Gets or sets the team attitude.
    /// </summary>
    /// <value>
    /// The team attitude.
    /// </value>
    public MatchTeamAttitude TeamAttitude { get; set; }
    /// <summary>
    /// Gets or sets the rating indirect set pieces definition.
    /// </summary>
    /// <value>
    /// The rating indirect set pieces definition.
    /// </value>
    public MatchRating RatingIndirectSetPiecesDef { get; set; }
    /// <summary>
    /// Gets or sets the rating indirect set pieces att.
    /// </summary>
    /// <value>
    /// The rating indirect set pieces att.
    /// </value>
    public MatchRating RatingIndirectSetPiecesAtt { get; set; }

}