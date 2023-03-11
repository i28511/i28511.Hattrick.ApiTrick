using i28511.Hattrick.ApiTrick.Enums;
using i28511.Hattrick.ApiTrick.MatchDetails;

namespace i28511.Hattrick.ApiTrick.Impl.MatchDetails
{
    internal static class Mappings
    {
        internal static Match ToMatch(this MatchXml xml)
        {

            if (xml is null)
                return null;

            return new Match
            {
                AddedMinutes = xml.AddedMinutes,
                Arena = xml.Arena.ToResponseModel(),
                AwayTeam = xml.AwayTeam.ToResponseModel(),
                Bookings = xml.Bookings != null ? xml.Bookings.Select(b => b.ToResponseModel()).ToList() : new List<Booking>(),
                CupLevel = xml.CupLevel,
                CupLevelIndex = xml.CupLevelIndex,
                FinishedDate = xml.FinishedDate.ToNullableDateTime(),
                HomeTeam = xml.HomeTeam.ToResponseModel(),
                Injuries = xml.Injuries != null ? xml.Injuries.Select(i => i.ToResponseModel()).ToList() : new List<Injury>(),
                MatchContextId = xml.MatchContextId,
                MatchDate = xml.MatchDate.ToDateTime(),
                MatchId = xml.MatchId,
                MatchOfficials = xml.MatchOfficials.ToResponseModel(),
                MatchRuleId = (MatchRuleType)xml.MatchRuleId,
                MatchType = (ApiTrick.Enums.MatchType)xml.MatchType,
                PossessionFirstHalfAway = xml.PossessionFirstHalfAway,
                PossessionFirstHalfHome = xml.PossessionFirstHalfHome,
                PossessionSecondHalfAway = xml.PossessionSecondHalfAway,
                PossessionSecondHalfHome = xml.PossessionSecondHalfHome,
                Scorers = xml.Scorers != null ? xml.Scorers.Select(s => s.ToResultModel()).ToList() : new List<Goal>()

            };
        }

        internal static Goal ToResultModel(this GoalXml xml)
        {
            if (xml is null)
                return null;
            return new Goal
            {
                MatchPart = (MatchPart)xml.MatchPart,
                ScorerAwayGoals = xml.ScorerAwayGoals,
                ScorerHomeGoals = xml.ScorerHomeGoals,
                ScorerMinute = xml.ScorerMinute,
                ScorerPlayerId = xml.ScorerPlayerId,
                ScorerPlayerName = xml.ScorerPlayerName,
                ScorerTeamId = xml.ScorerTeamId
            };
        }

        internal static MatchOfficials ToResponseModel(this MatchOfficialsXml xml)
        {
            if (xml is null)
                return null;
            return new MatchOfficials
            {
                Referee = xml.Referee.ToResponseModel(),
                RefereeAssistant1 = xml.RefereeAssistant1.ToResponseModel(),
                RefereeAssistant2 = xml.RefereeAssistant2.ToResponseModel()
            };
        }

        internal static Referee ToResponseModel(this RefereeXml xml)
        {
            if (xml is null)
                return null;
            return new Referee
            {
                RefereeCountryId = xml.RefereeCountryId,
                RefereeCountryName = xml.RefereeCountryName,
                RefereeId = xml.RefereeId,
                RefereeName = xml.RefereeName,
                RefereeTeamId = xml.RefereeTeamId,
                RefereeTeamname = xml.RefereeTeamName
            };
        }

        internal static Injury ToResponseModel(this InjuryXml xml)
        {
            if (xml is null)
                return null;
            return new Injury
            {
                InjuryMinute = xml.InjuryMinute,
                InjuryPlayerId = xml.InjuryPlayerId,
                InjuryPlayerName = xml.InjuryPlayerName,
                InjuryTeamId = xml.InjuryTeamId,
                InjuryType = (InjuryType)xml.InjuryType,
                MatchPart = (MatchPart)xml.MatchPart
            };
        }

        internal static Booking ToResponseModel(this BookingXml xml)
        {
            if (xml is null)
                return null;
            return new Booking
            {
                BookingMinute = xml.BookingMinute,
                BookingPlayerId = xml.BookingPlayerId,
                BookingPlayerName = xml.BookingPlayerName,
                BookingTeamId = xml.BookingTeamId,
                BookingType = (BookingType)xml.BookingType,
                MatchPart = (MatchPart)xml.MatchPart
            };
        }

        internal static Team ToResponseModel(this HomeTeamXml xml)
        {
            if (xml is null)
                return null;
            return new Team
            {
                DressUri = !string.IsNullOrEmpty(xml.DressUri) ? new Uri(xml.DressUri) : null,
                Formation = xml.Formation,
                Goals = xml.HomeGoals,
                RatingIndirectSetPiecesAtt = (MatchRating)xml.RatingIndirectSetPiecesAtt,
                RatingIndirectSetPiecesDef = (MatchRating)xml.RatingIndirectSetPiecesDef,
                RatingLeftAtt = (MatchRating)xml.RatingLeftAtt,
                RatingLeftDef = (MatchRating)xml.RatingLeftDef,
                RatingMidAtt = (MatchRating)xml.RatingMidAtt,
                RatingMidDef = (MatchRating)xml.RatingMidDef,
                RatingMidfield = (MatchRating)xml.RatingMidfield,
                RatingRightAtt = (MatchRating)xml.RatingRightAtt,
                RatingRightDef = (MatchRating)xml.RatingRightDef,
                TacticSkill = (SkillLevel)xml.TacticSkill,
                TacticType = (MatchTacticType)xml.TacticType,
                TeamAttitude = (MatchTeamAttitude)xml.TeamAttitude,
                TeamId = xml.HomeTeamId,
                TeamName = xml.HomeTeamName
            };
        }

        internal static Team ToResponseModel(this AwayTeamXml xml)
        {
            if (xml is null)
                return null;
            return new Team
            {
                DressUri = !string.IsNullOrEmpty(xml.DressUri) ? new Uri(xml.DressUri) : null,
                Formation = xml.Formation,
                Goals = xml.AwayGoals,
                RatingIndirectSetPiecesAtt = (MatchRating)xml.RatingIndirectSetPiecesAtt,
                RatingIndirectSetPiecesDef = (MatchRating)xml.RatingIndirectSetPiecesDef,
                RatingLeftAtt = (MatchRating)xml.RatingLeftAtt,
                RatingLeftDef = (MatchRating)xml.RatingLeftDef,
                RatingMidAtt = (MatchRating)xml.RatingMidAtt,
                RatingMidDef = (MatchRating)xml.RatingMidDef,
                RatingMidfield = (MatchRating)xml.RatingMidfield,
                RatingRightAtt = (MatchRating)xml.RatingRightAtt,
                RatingRightDef = (MatchRating)xml.RatingRightDef,
                TacticSkill = (SkillLevel)xml.TacticSkill,
                TacticType = (MatchTacticType)xml.TacticType,
                TeamAttitude = (MatchTeamAttitude)xml.TeamAttitude,
                TeamId = xml.AwayTeamId,
                TeamName = xml.AwayTeamName
            };
        }

        internal static Arena ToResponseModel(this ArenaXml xml)
        {
            if (xml is null)
                return null;
            return new Arena
            {
                ArenaId = xml.ArenaId,
                ArenaName = xml.ArenaName,
                SoldBasic = xml.SoldBasic,
                SoldRoof = xml.SoldRoof,
                SoldTerraces = xml.SoldTerraces,
                SoldTotal = xml.SoldTotal,
                SoldVip = xml.SoldVip,
                WeatherId = (WeatherType)xml.WeatherId
            };
        }
    }
}
