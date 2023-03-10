using i28511.Hattrick.ApiTrick.Impl.MatchDetails;
using System.Xml.Serialization;
using i28511.Hattrick.ApiTrick.Impl.Achievements;

namespace i28511.Hattrick.ApiTrick.Impl;

[XmlRoot(ElementName = "HattrickData")]
public class HattrickData
{
    [XmlElement("FileName")]
    public string FileName { get; set; }

    [XmlElement("Version")]
    public string Version { get; set; }

    [XmlElement("UserID")]
    public string UserId { get; set; }

    [XmlElement("FetchedDate")]
    public string FetchedDate { get; set; }

    [XmlElement("Error")]
    public HattrickError Error { get; set; }

    [XmlElement("Match")]
    public MatchXml Match { get; set; }

    [XmlElement("AchievementList")]
    public AchievementListXml AchievementList { get; set; }
}