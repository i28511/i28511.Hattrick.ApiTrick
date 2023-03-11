using i28511.Hattrick.ApiTrick.Achievements;
using i28511.Hattrick.ApiTrick.Enums;

namespace i28511.Hattrick.ApiTrick.Impl.Achievements
{
    internal static class Mappings
    {
        public static Achievement ToAchievement(this AchievementListAchievement xml)
        {
            if (xml is null)
                return null;

            return new Achievement
            {
                AchievementText = xml.AchievementText,
                AchievementTitle = xml.AchievementTitle,
                AchievementTypeId = xml.AchievementTypeID,
                CategoryId = (AchievementCategoryType)xml.CategoryID,
                EventDate = xml.EventDate.ToDateTime(),
                MultiLevel = bool.Parse(xml.MultiLevel.ToLower()),
                NumberOfEvents = xml.NumberOfEvents,
                Points = xml.Points,
                Rank = xml.Rank
            };
        }
    }
}
