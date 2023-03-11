using i28511.Hattrick.ApiTrick.Enums;

namespace i28511.Hattrick.ApiTrick.Achievements
{
    public class Achievement
    {
        public int AchievementTypeId { get; set; }
        public string AchievementTitle { get; set; }
        public string AchievementText { get; set; }
        public AchievementCategoryType CategoryId { get; set; }
        public DateTime EventDate { get; set; }
        public int Points { get; set; }
        public bool MultiLevel { get; set; }
        public int Rank { get; set; }
        public int NumberOfEvents { get; set; }
    }
}
