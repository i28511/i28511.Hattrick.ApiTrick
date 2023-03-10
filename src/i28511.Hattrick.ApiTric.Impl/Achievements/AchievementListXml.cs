using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl.Achievements;

public class AchievementListXml
{

    private AchievementListAchievement[] achievementField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Achievement")]
    public AchievementListAchievement[] Achievement
    {
        get
        {
            return this.achievementField;
        }
        set
        {
            this.achievementField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class AchievementListAchievement
{

    private byte achievementTypeIDField;

    private string achievementTitleField;

    private string achievementTextField;

    private byte categoryIDField;

    private string eventDateField;

    private byte pointsField;

    private string multiLevelField;

    private byte rankField;

    private uint numberOfEventsField;

    /// <remarks/>
    public byte AchievementTypeID
    {
        get
        {
            return this.achievementTypeIDField;
        }
        set
        {
            this.achievementTypeIDField = value;
        }
    }

    /// <remarks/>
    public string AchievementTitle
    {
        get
        {
            return this.achievementTitleField;
        }
        set
        {
            this.achievementTitleField = value;
        }
    }

    /// <remarks/>
    public string AchievementText
    {
        get
        {
            return this.achievementTextField;
        }
        set
        {
            this.achievementTextField = value;
        }
    }

    /// <remarks/>
    public byte CategoryID
    {
        get
        {
            return this.categoryIDField;
        }
        set
        {
            this.categoryIDField = value;
        }
    }

    /// <remarks/>
    public string EventDate
    {
        get
        {
            return this.eventDateField;
        }
        set
        {
            this.eventDateField = value;
        }
    }

    /// <remarks/>
    public byte Points
    {
        get
        {
            return this.pointsField;
        }
        set
        {
            this.pointsField = value;
        }
    }

    /// <remarks/>
    public string MultiLevel
    {
        get
        {
            return this.multiLevelField;
        }
        set
        {
            this.multiLevelField = value;
        }
    }

    /// <remarks/>
    public byte Rank
    {
        get
        {
            return this.rankField;
        }
        set
        {
            this.rankField = value;
        }
    }

    /// <remarks/>
    public uint NumberOfEvents
    {
        get
        {
            return this.numberOfEventsField;
        }
        set
        {
            this.numberOfEventsField = value;
        }
    }
}

