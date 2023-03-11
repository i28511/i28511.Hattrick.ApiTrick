using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl.Achievements;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class AchievementListXml
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

    private int achievementTypeIDField;

    private string achievementTitleField;

    private string achievementTextField;

    private int categoryIDField;

    private string eventDateField;

    private int pointsField;

    private string multiLevelField;

    private int rankField;

    private int numberOfEventsField;

    /// <remarks/>
    public int AchievementTypeID
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
    public int CategoryID
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
    public int Points
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
    public int Rank
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
    public int NumberOfEvents
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



