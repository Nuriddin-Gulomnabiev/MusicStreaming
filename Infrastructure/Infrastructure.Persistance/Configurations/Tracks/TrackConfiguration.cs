using Domain.Entities.Tracks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Infrastructure.Persistance.Configurations.Albums.AlbumConfiguration;

namespace Infrastructure.Persistance.Configurations.Tracks
{
    public class TrackConfiguration : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(70).IsRequired();
            builder.Property(p => p.Code).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Number).IsRequired().HasDefaultValue(1);

            builder.HasOne(e => e.Album).WithMany(p => p.Tracks).HasForeignKey(p => p.AlbumId);

            builder.HasData(
            #region 17
                new Track { Id = _17TrackIdEnum.TheExplanation, AlbumId = AlbumIdEnum._17, Name = "The Explanation", Duration = 1.1m, IsActive = true },
                new Track { Id = _17TrackIdEnum.JocelynFlores, AlbumId = AlbumIdEnum._17, Name = "Jocelyn Flores", IsActive = true },
                new Track { Id = _17TrackIdEnum.DepressionObsession, AlbumId = AlbumIdEnum._17, Name = "Depression & Obsession", IsActive = true },
                new Track { Id = _17TrackIdEnum.EverybodyDiesInTheirNightmares, AlbumId = AlbumIdEnum._17, Name = "Everybody Dies In Their Nightmares", IsActive = true },
                new Track { Id = _17TrackIdEnum.Revenge, AlbumId = AlbumIdEnum._17, Name = "Revenge", IsActive = true },
                new Track { Id = _17TrackIdEnum.SaveMe, AlbumId = AlbumIdEnum._17, Name = "Save Me", IsActive = true },
                new Track { Id = _17TrackIdEnum.DeadInsideInterlude, AlbumId = AlbumIdEnum._17, Name = "Dead Inside (Interlude)", IsActive = true },
                new Track { Id = _17TrackIdEnum.FuckLove, AlbumId = AlbumIdEnum._17, Name = "Fuck Love feat. Trippie Redd", IsActive = true },
                new Track { Id = _17TrackIdEnum.CarryOn, AlbumId = AlbumIdEnum._17, Name = "Carry On", IsActive = true },
                new Track { Id = _17TrackIdEnum.Orlando, AlbumId = AlbumIdEnum._17, Name = "Orlando", IsActive = true },
                new Track { Id = _17TrackIdEnum.AyalaOutro, AlbumId = AlbumIdEnum._17, Name = "Ayala (Outro)", IsActive = true },
            #endregion
            #region Whole Lotta Red
                new Track { Id = WholeLottaRedTrackIdEnum.Teen, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Teen", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.NotPlaying, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Not PLaying", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.JumpOutTheHouse, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "JumpOutTheHouse", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.NewN3on, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "New N3on", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.Slay3r, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Slay3r", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.Die4Guy, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Die4Guy", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.Place, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Place", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.Metamorphosis, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Metamorphosis", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.Control, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Control", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.AtMEH, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "@ MEH", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.F33lLik3Dyin, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "F33l Lik3 Dyin", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.Over, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Over", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.KingVamp, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "King Vamp", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.MoneyAndDrugs, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Money And Drugs", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.OnThatTime, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "On That Time", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.Beno, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Beno!", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.VampAnthem, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Vamp Anthem", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.Go2DaMoon, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Go2DaMoon", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.ILoveUIHateU, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "ILoveUIHateU", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.RockstarMade, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Rockstar Made", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.PunkMonk, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Punk Monk", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.Sky, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Sky", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.StopBreathing, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "Stop Breathing", IsActive = true },
                new Track { Id = WholeLottaRedTrackIdEnum.NewTank, AlbumId = AlbumIdEnum.WholeLottaRed, Name = "New Tank", IsActive = true },
            #endregion
            #region Red & White
                new Track { Id = RedWhiteTrackIdEnum.SpaceCadet, AlbumId = AlbumIdEnum.RedWhite, Name = "Space Cadet", IsActive = true },
                new Track { Id = RedWhiteTrackIdEnum.IKnow, AlbumId = AlbumIdEnum.RedWhite, Name = "I Know", IsActive = true },
                new Track { Id = RedWhiteTrackIdEnum.FlexUp, AlbumId = AlbumIdEnum.RedWhite, Name = "Flex Up", IsActive = true },
                new Track { Id = RedWhiteTrackIdEnum.HittinMyShoulder, AlbumId = AlbumIdEnum.RedWhite, Name = "Hittin My Shoulder", IsActive = true },
                new Track { Id = RedWhiteTrackIdEnum.Cigarette, AlbumId = AlbumIdEnum.RedWhite, Name = "Cigarette", IsActive = true },
                new Track { Id = RedWhiteTrackIdEnum.ForFun, AlbumId = AlbumIdEnum.RedWhite, Name = "For Fun", IsActive = true },
                new Track { Id = RedWhiteTrackIdEnum.BelieveMe, AlbumId = AlbumIdEnum.RedWhite, Name = "Believe Me", IsActive = true },
                new Track { Id = RedWhiteTrackIdEnum.IssaHit, AlbumId = AlbumIdEnum.RedWhite, Name = "Issa Hit", IsActive = true },
                new Track { Id = RedWhiteTrackIdEnum.GlockInMyPurse, AlbumId = AlbumIdEnum.RedWhite, Name = "Glock in My Purse", IsActive = true },
                new Track { Id = RedWhiteTrackIdEnum.FinalFantasy, AlbumId = AlbumIdEnum.RedWhite, Name = "Final Fantasy", IsActive = true },
            #endregion
            #region LifeOfPierre5
                new Track { Id = LOP5TrackIdEnum.LOP5Intro, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Intro", Duration = 1.11m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.SwitchingLanes, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Switching Lanes (feat. Playboi Carti)", Duration = 3.10m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.HULU, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "HULU", Duration = 5.13m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.Couch, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Couch", Duration = 4.24m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum._42, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "42", Duration = 3.07m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.Biology101, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Biology 101", Duration = 3.08m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.YNS, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "YNS", Duration = 4.19m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.Sossboy2, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Sossboy 2 (feat. Lil Uzi Vert)", Duration = 3.47m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.Practice, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Practice", Duration = 4.33m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum._40Clip, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "40 Clip", Duration = 4.27m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.Retroville, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Retroville", Duration = 4.51m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.DrunkAndNasty, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Drunk And Nasty (feat. Sharc)", Duration = 5.00m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.Amen, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Amen", Duration = 2.59m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.Groceries, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Groceries", Duration = 3.12m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum.Butterfly, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "Butterfly", Duration = 3.15m, IsActive = true },
                new Track { Id = LOP5TrackIdEnum._4U, AlbumId = AlbumIdEnum.LifeOfPierre5, Name = "4U", IsActive = true },
            #endregion
            #region Scorpion
                new Track { Id = ScorpionTrackIdEnum.Survival, AlbumId = AlbumIdEnum.Scorpion, Name = "Survival", Duration = 2.16m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.Nonstop, AlbumId = AlbumIdEnum.Scorpion, Name = "Nonstop", Duration = 3.58m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.Elevate, AlbumId = AlbumIdEnum.Scorpion, Name = "Elevate", Duration = 3.04m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.Emotionless, AlbumId = AlbumIdEnum.Scorpion, Name = "Emotionless", Duration = 5.02m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.GodsPlan, AlbumId = AlbumIdEnum.Scorpion, Name = "God's Plan", Duration = 3.19m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.ImUpset, AlbumId = AlbumIdEnum.Scorpion, Name = "I'm Upset", Duration = 3.34m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.EightOutOfTen, AlbumId = AlbumIdEnum.Scorpion, Name = "8 Out of 10", Duration = 3.15m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.MobTies, AlbumId = AlbumIdEnum.Scorpion, Name = "Mob Ties", Duration = 3.25m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.CantTakeAJoke, AlbumId = AlbumIdEnum.Scorpion, Name = "Can't Take a Joke", Duration = 2.43m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.SandrasRose, AlbumId = AlbumIdEnum.Scorpion, Name = "Sandra's Rose", Duration = 3.36m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.TalkUp, AlbumId = AlbumIdEnum.Scorpion, Name = "Talk Up", Duration = 3.15m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.IsThereMore, AlbumId = AlbumIdEnum.Scorpion, Name = "Is There More", Duration = 3.46m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.Peak, AlbumId = AlbumIdEnum.Scorpion, Name = "Peak", Duration = 3.26m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.SummerGames, AlbumId = AlbumIdEnum.Scorpion, Name = "Summer Games", Duration = 4.07m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.Jaded, AlbumId = AlbumIdEnum.Scorpion, Name = "Jaded", Duration = 4.22m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.NiceForWhat, AlbumId = AlbumIdEnum.Scorpion, Name = "Nice for What", Duration = 3.30m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.Finesse, AlbumId = AlbumIdEnum.Scorpion, Name = "Finesse", Duration = 3.02m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.RatchetHappyBirthday, AlbumId = AlbumIdEnum.Scorpion, Name = "Ratchet Happy Birthday", Duration = 3.27m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.ThatsHowYouFeel, AlbumId = AlbumIdEnum.Scorpion, Name = "That's How You Feel", Duration = 2.37m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.BlueTint, AlbumId = AlbumIdEnum.Scorpion, Name = "Blue Tint", Duration = 2.42m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.InMyFeelings, AlbumId = AlbumIdEnum.Scorpion, Name = "In My Feelings", Duration = 3.37m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.DontMatterToMe, AlbumId = AlbumIdEnum.Scorpion, Name = "Don't Matter to Me", Duration = 4.05m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.AfterDark, AlbumId = AlbumIdEnum.Scorpion, Name = "After Dark", Duration = 4.49m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.FinalFantasy, AlbumId = AlbumIdEnum.Scorpion, Name = "Final Fantasy", Duration = 3.39m, IsActive = true },
                new Track { Id = ScorpionTrackIdEnum.March14, AlbumId = AlbumIdEnum.Scorpion, Name = "March 14", Duration = 5.09m, IsActive = true },
            #endregion
            #region 1989
                new Track { Id = _1989TrackIdEnum.WelcomeToNewYork, AlbumId = AlbumIdEnum._1989, Name = "WelcomeToNewYork", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.BlankSpace, AlbumId = AlbumIdEnum._1989, Name = "BlankSpace", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.Style, AlbumId = AlbumIdEnum._1989, Name = "Style", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.OutOfTheWoods, AlbumId = AlbumIdEnum._1989, Name = "OutOfTheWoods", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.AllYouHadToDoWasStay, AlbumId = AlbumIdEnum._1989, Name = "AllYouHadToDoWasStay", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.ShakeItOff, AlbumId = AlbumIdEnum._1989, Name = "ShakeItOff", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.IWishYouWould, AlbumId = AlbumIdEnum._1989, Name = "I Wish You Would", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.BadBlood, AlbumId = AlbumIdEnum._1989, Name = "BadBlood", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.WildestDreams, AlbumId = AlbumIdEnum._1989, Name = "WildestDreams", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.HowYouGetTheGirl, AlbumId = AlbumIdEnum._1989, Name = "HowYouGetTheGirl", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.ThisLove, AlbumId = AlbumIdEnum._1989, Name = "ThisLove", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.IKnowPlaces, AlbumId = AlbumIdEnum._1989, Name = "I Know Places", Duration = 2.16m, IsActive = true },
                new Track { Id = _1989TrackIdEnum.Clean, AlbumId = AlbumIdEnum._1989, Name = "Clean", Duration = 2.16m, IsActive = true },
            #endregion
            #region _24KMagic
                new Track { Id = _24KMagicTrackIdEnum._24KMagic, AlbumId = AlbumIdEnum._24KMagic, Name = "24KMagic", Duration = 2.16m, IsActive = true },
                new Track { Id = _24KMagicTrackIdEnum.Chunky, AlbumId = AlbumIdEnum._24KMagic, Name = "Chunky", Duration = 2.16m, IsActive = true },
                new Track { Id = _24KMagicTrackIdEnum.Perm, AlbumId = AlbumIdEnum._24KMagic, Name = "Perm", Duration = 2.16m, IsActive = true },
                new Track { Id = _24KMagicTrackIdEnum.ThatsWhatILike, AlbumId = AlbumIdEnum._24KMagic, Name = "That'sWhatILike", Duration = 2.16m, IsActive = true },
                new Track { Id = _24KMagicTrackIdEnum.VersaceOnTheFloor, AlbumId = AlbumIdEnum._24KMagic, Name = "VersaceOnTheFloor", Duration = 2.16m, IsActive = true },
                new Track { Id = _24KMagicTrackIdEnum.StraightUpAndDown, AlbumId = AlbumIdEnum._24KMagic, Name = "StraightUpAndDown", Duration = 2.16m, IsActive = true },
                new Track { Id = _24KMagicTrackIdEnum.CallingAllMyLovelies, AlbumId = AlbumIdEnum._24KMagic, Name = "CallingAllMyLovelies", Duration = 2.16m, IsActive = true },
                new Track { Id = _24KMagicTrackIdEnum.Finesse, AlbumId = AlbumIdEnum._24KMagic, Name = "Finesse", Duration = 2.16m, IsActive = true },
                new Track { Id = _24KMagicTrackIdEnum.TooGoodToSayGoodbye, AlbumId = AlbumIdEnum._24KMagic, Name = "TooGoodToSayGoodbye", Duration = 2.16m, IsActive = true },
            #endregion
            #region Anti
                new Track { Id = AntiTrackIdEnum.Consideration, AlbumId = AlbumIdEnum.Anti, Name = "Consideration", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.JamesJoint, AlbumId = AlbumIdEnum.Anti, Name = "JamesJoint", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.KissItBetter, AlbumId = AlbumIdEnum.Anti, Name = "KissItBetter", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.Work, AlbumId = AlbumIdEnum.Anti, Name = "Work", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.Desperado, AlbumId = AlbumIdEnum.Anti, Name = "Desperado", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.Woo, AlbumId = AlbumIdEnum.Anti, Name = "Woo", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.NeededMe, AlbumId = AlbumIdEnum.Anti, Name = "NeededMe", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.YeahImThOne, AlbumId = AlbumIdEnum.Anti, Name = "YeahImThOne", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.SameOlMistakes, AlbumId = AlbumIdEnum.Anti, Name = "SameOlMistakes", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.NeverEnding, AlbumId = AlbumIdEnum.Anti, Name = "NeverEnding", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.LoveOnTheBrain, AlbumId = AlbumIdEnum.Anti, Name = "LoveOnTheBrain", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.Higher, AlbumId = AlbumIdEnum.Anti, Name = "Higher", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.CloseToYou, AlbumId = AlbumIdEnum.Anti, Name = "CloseToYou", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.GoodNightGotham, AlbumId = AlbumIdEnum.Anti, Name = "GoodNightGotham", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.Pose, AlbumId = AlbumIdEnum.Anti, Name = "Pose", Duration = 2.16m, IsActive = true },
                new Track { Id = AntiTrackIdEnum.SexWithMe, AlbumId = AlbumIdEnum.Anti, Name = "SexWithMe", Duration = 2.16m, IsActive = true },
            #endregion
            #region DAMN
                new Track { Id = DAMNTrackIdEnum.BLOOD, AlbumId = AlbumIdEnum.DAMN, Name = "BLOOD", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.DNA, AlbumId = AlbumIdEnum.DAMN, Name = "DNA", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.YAH, AlbumId = AlbumIdEnum.DAMN, Name = "YAH", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.ELEMENT, AlbumId = AlbumIdEnum.DAMN, Name = "ELEMENT", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.FEEL, AlbumId = AlbumIdEnum.DAMN, Name = "FEEL", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.LOYALTY, AlbumId = AlbumIdEnum.DAMN, Name = "LOYALTY", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.PRIDE, AlbumId = AlbumIdEnum.DAMN, Name = "PRIDE", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.HUMBLE, AlbumId = AlbumIdEnum.DAMN, Name = "HUMBLE", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.LUST, AlbumId = AlbumIdEnum.DAMN, Name = "LUST", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.LOVE, AlbumId = AlbumIdEnum.DAMN, Name = "LOVE", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.XXX, AlbumId = AlbumIdEnum.DAMN, Name = "XXX", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.FEAR, AlbumId = AlbumIdEnum.DAMN, Name = "FEAR", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.GOD, AlbumId = AlbumIdEnum.DAMN, Name = "GOD", Duration = 2.16m, IsActive = true },
                new Track { Id = DAMNTrackIdEnum.DUCKWORTH, AlbumId = AlbumIdEnum.DAMN, Name = "DUCKWORTH", Duration = 2.16m, IsActive = true },
            #endregion
            #region WhenWeAllFallAsleep
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.exclamationMark, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "exclamationMark", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.badguy, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "badguy", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.xanny, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "xanny", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.youshouldseemeinacrown, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "youshouldseemeinacrown", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.allthegoodgirlsgotohell, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "allthegoodgirlsgotohell", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.wishyouweregay, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "wishyouweregay", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.whenthepartysover, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "whenthepartysover", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum._8, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "_8", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.mystrangeaddiction, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "mystrangeaddiction", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.buryafriend, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "buryafriend", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.ilomilo, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "ilomilo", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.listenbeforeigo, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "listenbeforeigo", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.iloveyou, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "iloveyou", Duration = 2.16m, IsActive = true },
                new Track { Id = WhenWeAllFallAsleepTrackIdEnum.goodbye, AlbumId = AlbumIdEnum.WhenWeAllFallAsleep, Name = "goodbye", Duration = 2.16m, IsActive = true },
            #endregion
            #region Purpose
                new Track { Id = PurposeTrackIdEnum.MarkMyWords, AlbumId = AlbumIdEnum.Purpose, Name = "MarkMyWords", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.ILlShowYou, AlbumId = AlbumIdEnum.Purpose, Name = "ILlShowYou", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.WhatDoYouMean, AlbumId = AlbumIdEnum.Purpose, Name = "WhatDoYouMean", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.Sorry, AlbumId = AlbumIdEnum.Purpose, Name = "Sorry", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.LoveYourself, AlbumId = AlbumIdEnum.Purpose, Name = "LoveYourself", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.Company, AlbumId = AlbumIdEnum.Purpose, Name = "Company", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.NoPressure, AlbumId = AlbumIdEnum.Purpose, Name = "NoPressure", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.NoSense, AlbumId = AlbumIdEnum.Purpose, Name = "NoSense", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.TheFeeling, AlbumId = AlbumIdEnum.Purpose, Name = "TheFeeling", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.LifeIsWorthLiving, AlbumId = AlbumIdEnum.Purpose, Name = "LifeIsWorthLiving", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.WhereAreUNow, AlbumId = AlbumIdEnum.Purpose, Name = "WhereAreUNow", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.Children, AlbumId = AlbumIdEnum.Purpose, Name = "Children", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.Purpose, AlbumId = AlbumIdEnum.Purpose, Name = "Purpose", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.BeenYou, AlbumId = AlbumIdEnum.Purpose, Name = "BeenYou", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.GetUsedToIt, AlbumId = AlbumIdEnum.Purpose, Name = "GetUsedToIt", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.WeAre, AlbumId = AlbumIdEnum.Purpose, Name = "WeAre", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.Trust, AlbumId = AlbumIdEnum.Purpose, Name = "Trust", Duration = 2.16m, IsActive = true },
                new Track { Id = PurposeTrackIdEnum.AllInIt, AlbumId = AlbumIdEnum.Purpose, Name = "AllInIt", Duration = 2.16m, IsActive = true },
            #endregion

            #region Sweetener
    new Track { Id = SweetenerTrackIdEnum.Raindrops, AlbumId = AlbumIdEnum.Sweetener, Name = "Raindrops", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.Blazed, AlbumId = AlbumIdEnum.Sweetener, Name = "Blazed", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.TheLightIsComing, AlbumId = AlbumIdEnum.Sweetener, Name = "TheLightIsComing", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.REM, AlbumId = AlbumIdEnum.Sweetener, Name = "R.E.M.", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.GodIsAWoman, AlbumId = AlbumIdEnum.Sweetener, Name = "GodIsAWoman", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.Sweetener, AlbumId = AlbumIdEnum.Sweetener, Name = "Sweetener", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.Successful, AlbumId = AlbumIdEnum.Sweetener, Name = "Successful", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.Everytime, AlbumId = AlbumIdEnum.Sweetener, Name = "Everytime", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.Breathin, AlbumId = AlbumIdEnum.Sweetener, Name = "Breathin", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.NoTearsLefttoCry, AlbumId = AlbumIdEnum.Sweetener, Name = "NoTearsLefttoCry", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.Borderline, AlbumId = AlbumIdEnum.Sweetener, Name = "Borderline", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.BetterOff, AlbumId = AlbumIdEnum.Sweetener, Name = "BetterOff", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.GoodnightNGo, AlbumId = AlbumIdEnum.Sweetener, Name = "GoodnightNGo", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.PeteDavidson, AlbumId = AlbumIdEnum.Sweetener, Name = "PeteDavidson", Duration = 2.16m, IsActive = true },
                new Track { Id = SweetenerTrackIdEnum.GetWellSoon, AlbumId = AlbumIdEnum.Sweetener, Name = "GetWellSoon", Duration = 2.16m, IsActive = true },
            #endregion
            #region Divide
                new Track { Id = DivideTrackIdEnum.Eraser, AlbumId = AlbumIdEnum.Divide, Name = "Eraser", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.CastleontheHill, AlbumId = AlbumIdEnum.Divide, Name = "CastleontheHill", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.Dive, AlbumId = AlbumIdEnum.Divide, Name = "Dive", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.ShapeofYou, AlbumId = AlbumIdEnum.Divide, Name = "ShapeofYou", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.Perfect, AlbumId = AlbumIdEnum.Divide, Name = "Perfect", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.GalwayGirl, AlbumId = AlbumIdEnum.Divide, Name = "GalwayGirl", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.Happier, AlbumId = AlbumIdEnum.Divide, Name = "Happier", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.NewMan, AlbumId = AlbumIdEnum.Divide, Name = "New Man", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.HeartsDontBreakAroundHere, AlbumId = AlbumIdEnum.Divide, Name = "HeartsDontBreakAroundHere", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.WhatDoIKnow, AlbumId = AlbumIdEnum.Divide, Name = "WhatDoIKnow", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.HowWouldYouFeelPaean, AlbumId = AlbumIdEnum.Divide, Name = "HowWouldYouFeelPaean", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.SupermarketFlowers, AlbumId = AlbumIdEnum.Divide, Name = "SupermarketFlowers", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.Barcelona, AlbumId = AlbumIdEnum.Divide, Name = "Barcelona", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.BibiaBeYeYe, AlbumId = AlbumIdEnum.Divide, Name = "BibiaBeYeYe", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.NancyMulligan, AlbumId = AlbumIdEnum.Divide, Name = "NancyMulligan", Duration = 2.16m, IsActive = true },
                new Track { Id = DivideTrackIdEnum.SaveMyself, AlbumId = AlbumIdEnum.Divide, Name = "SaveMyself", Duration = 2.16m, IsActive = true }
                #endregion
            );
        }

        internal static class _17TrackIdEnum
        {
            public static Guid TheExplanation = new Guid("8366834f-0278-46e2-8142-011813bda329");
            public static Guid JocelynFlores = new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a");
            public static Guid DepressionObsession = new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad");
            public static Guid EverybodyDiesInTheirNightmares = new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b");
            public static Guid Revenge = new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a");
            public static Guid SaveMe = new Guid("baace2ca-c2c0-4cee-b129-53079d696059");
            public static Guid DeadInsideInterlude = new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a");
            public static Guid FuckLove = new Guid("6d342342-ea26-40f4-aa92-420f3a943603");
            public static Guid CarryOn = new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce");
            public static Guid Orlando = new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1");
            public static Guid AyalaOutro = new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828");
        }

        internal static class WhenWeAllFallAsleepTrackIdEnum
        {
            public static readonly Guid exclamationMark = new Guid("f32391b1-d252-406f-a7f5-fe523c531e1d");
            public static readonly Guid badguy = new Guid("617a9867-2fcc-4d05-8bb8-857689a35b17");
            public static readonly Guid xanny = new Guid("454bfdb6-4922-45b8-bd0d-33c38da31735");
            public static readonly Guid youshouldseemeinacrown = new Guid("c25f19d4-883b-47a6-b2ba-05691f039db3");
            public static readonly Guid allthegoodgirlsgotohell = new Guid("361a2eef-a9b0-4b5e-9c00-9bacfb5341a2");
            public static readonly Guid wishyouweregay = new Guid("5793b9c8-72ce-47c6-93ca-4c5c7f032b98");
            public static readonly Guid whenthepartysover = new Guid("eebee09c-ddc4-43c4-9e1e-95c14f2bb1fb");
            public static readonly Guid _8 = new Guid("4cb98d94-2541-45ec-a178-f32e4faf7ddf");
            public static readonly Guid mystrangeaddiction = new Guid("2cacb4aa-113f-4acd-b677-816bae840b08");
            public static readonly Guid buryafriend = new Guid("cf50b71c-4055-4276-8f82-e9e91ce88049");
            public static readonly Guid ilomilo = new Guid("0645bf34-df24-4681-a088-3430ac64f013");
            public static readonly Guid listenbeforeigo = new Guid("93dc2a4e-e14b-4fb8-84b5-ab244110e423");
            public static readonly Guid iloveyou = new Guid("85efc138-f29f-4d8e-9b05-da95bec1e203");
            public static readonly Guid goodbye = new Guid("9484a78d-b1fd-401e-904d-4d9ba1e30fea");
        }

        internal static class WholeLottaRedTrackIdEnum
        {
            public static Guid Teen = new Guid("262342b2-861e-4802-a54c-c84522188cd7");
            public static Guid NotPlaying = new Guid("3fde47fd-c654-4124-bc46-88d3b9bfa4df");
            public static Guid JumpOutTheHouse = new Guid("6c9645b5-3f50-4a11-8be0-314a97c27eb8");
            public static Guid NewN3on = new Guid("f0a91ef7-1eaa-40d0-8273-0401bea48b5c");
            public static Guid Slay3r = new Guid("8842e1a3-18e2-4aa7-8b66-55150248a33a");
            public static Guid Die4Guy = new Guid("2d75a3c6-1e6b-4740-afaa-60e33bcb77e3");
            public static Guid Place = new Guid("5d146662-869d-477f-8f99-620ad1f3c1d1");
            public static Guid Metamorphosis = new Guid("82e5f6d3-1d4a-4bc2-96d0-2d8f7852bc7e");
            public static Guid Control = new Guid("08d03e3d-0919-4c01-a6db-78c2abfc4d5e");
            public static Guid AtMEH = new Guid("e9481c7b-c007-46de-b706-4775c1d9c6de");
            public static Guid F33lLik3Dyin = new Guid("bf9e77fd-3d3a-4a77-aae9-123d03b9a2e4");
            public static Guid Over = new Guid("6b24c35d-8589-4d35-83be-dfc48f0c8a79");
            public static Guid KingVamp = new Guid("9b17852c-5733-494d-8c37-ecf91fbc668f");
            public static Guid MoneyAndDrugs = new Guid("a633f860-97ce-4d9a-9960-2091db4aee78");
            public static Guid OnThatTime = new Guid("d982cc75-bcfc-4c66-8dd6-23b1e87866e5");
            public static Guid Beno = new Guid("d1c9e7c7-ee5e-4ae7-8d5e-bdb94e10bcb9");
            public static Guid VampAnthem = new Guid("4d60248e-d3f1-43e0-978f-356947c53e15");
            public static Guid Go2DaMoon = new Guid("ddaa72b5-3a20-46d7-8c48-c6c7c9ea2564");
            public static Guid ILoveUIHateU = new Guid("997f8ae9-cc5d-4b19-9dd7-0f1d287106e9");
            public static Guid RockstarMade = new Guid("5e8eae8c-7d72-4dc0-9832-6ae82f5a42ed");
            public static Guid PunkMonk = new Guid("15dc8b5e-f87e-4ee6-8f0b-6c1f1e2f5eb1");
            public static Guid Sky = new Guid("c138c0a3-0dbd-4b9c-9533-d860bb4d1364");
            public static Guid StopBreathing = new Guid("f89c0c4d-59e4-4b9a-b95f-8c6d2fb4208b");
            public static Guid NewTank = new Guid("e43d89cd-398d-4dbb-99e6-789869f891f3");
        }

        internal static class RedWhiteTrackIdEnum
        {
            public static readonly Guid SpaceCadet = new Guid("c878736d-da07-4401-ab27-2743d4e035c5");
            public static readonly Guid IKnow = new Guid("9a38a1d3-91c6-4f0e-b5b9-7d9b542cdd15");
            public static readonly Guid FlexUp = new Guid("a3fe58cc-ba59-4e09-96a1-4f9e8f77f99b");
            public static readonly Guid HittinMyShoulder = new Guid("1e4b79fc-4f83-44d2-95c4-35b69f62c3ab");
            public static readonly Guid Cigarette = new Guid("b36a20bc-04a1-4c9c-8a07-5270d1526c7e");
            public static readonly Guid ForFun = new Guid("3d8e0d8f-8b9a-4f54-9e13-3a9d7db4ce41");
            public static readonly Guid BelieveMe = new Guid("3e4d4f4d-46f5-4716-9b8b-c355e66b8832");
            public static readonly Guid IssaHit = new Guid("d48b865a-10ef-4f6e-aae9-58ef614fc16f");
            public static readonly Guid GlockInMyPurse = new Guid("190e4a84-462b-4a3e-90e4-9e25a826c4d3");
            public static readonly Guid FinalFantasy = new Guid("0e53296d-4f08-4a15-ae64-23a8f4e8d804");
        }

        internal static class LOP5TrackIdEnum
        {
            public static readonly Guid LOP5Intro = new Guid("674a432f-3fd4-4b33-af25-82607c96a3f0");
            public static readonly Guid SwitchingLanes = new Guid("b68c8431-5b79-4492-9f60-9f977fd471d7");
            public static readonly Guid HULU = new Guid("066d0b1d-b7c6-40b6-a48c-1f7b83084760");
            public static readonly Guid Couch = new Guid("f840d9d0-7ecf-4b7c-b4e6-50118a1f6712");
            public static readonly Guid _42 = new Guid("41b26f20-69e4-43d2-8db4-76ed6a5028b3");
            public static readonly Guid Biology101 = new Guid("bea11ee9-0d72-4d56-b27c-33095a0787a7");
            public static readonly Guid YNS = new Guid("8b9df2a6-df2f-4c52-83d3-03aeb745e3e3");
            public static readonly Guid Sossboy2 = new Guid("61458d69-7f4a-406d-80e3-7ff0d65e7f5f");
            public static readonly Guid Practice = new Guid("4fca4e84-f34c-4b73-8a66-3d1566763a8a");
            public static readonly Guid _40Clip = new Guid("7541417e-d9db-45c5-95f3-146b6f43f523");
            public static readonly Guid Retroville = new Guid("96b13d9a-3a2d-4a61-9616-6f2f2a2e0de4");
            public static readonly Guid DrunkAndNasty = new Guid("6a4b25d6-ae03-4aee-a442-af50945f1aee");
            public static readonly Guid Amen = new Guid("0a41a3fe-6f5d-4d23-9a34-34a11b5b438b");
            public static readonly Guid Groceries = new Guid("3f3ef649-9e39-4bda-85e5-3d763f01c31e");
            public static readonly Guid Butterfly = new Guid("b8fd88fb-647e-4130-83ed-801a9abf5e75");
            public static readonly Guid _4U = new Guid("2fb86013-0a56-4f2a-bd99-3fd4f4c1f1f3");
        }

        internal static class PurposeTrackIdEnum
        {
            public static readonly Guid MarkMyWords = new Guid("9b7ad1c8-fdd9-4b7a-891b-e7270998f885");
            public static readonly Guid ILlShowYou = new Guid("da1fcc3b-1841-4e3b-b75b-1292385ef9bf");
            public static readonly Guid WhatDoYouMean = new Guid("7b7345e4-8ac4-4dd4-a6c7-4bbd713494aa");
            public static readonly Guid Sorry = new Guid("76d9e174-1e56-4e71-ab06-673753e381aa");
            public static readonly Guid LoveYourself = new Guid("7ff0824a-e240-4ddd-bd2d-9406f6296b53");
            public static readonly Guid Company = new Guid("38b6bae0-b77b-4547-9884-64ec9e9eaadc");
            public static readonly Guid NoPressure = new Guid("52126cb0-f858-4f29-bd76-fa480a15daf3");
            public static readonly Guid NoSense = new Guid("8fa99920-8bd6-4da4-b530-fef34656fa2b");
            public static readonly Guid TheFeeling = new Guid("fcb99dc8-d3f3-4b11-93c1-b8356f4bd87d");
            public static readonly Guid LifeIsWorthLiving = new Guid("48b05998-fb99-4693-98af-af675b4ddf46");
            public static readonly Guid WhereAreUNow = new Guid("6daaee3d-1e84-4408-aff9-eb7c02a25b14");
            public static readonly Guid Children = new Guid("1648caba-362b-4974-bcc5-78a4b241cc26");
            public static readonly Guid Purpose = new Guid("dc3a0d3f-204d-4efe-80c0-f590eb22baee");
            public static readonly Guid BeenYou = new Guid("5cda7056-6608-4a10-b2ac-e4542a3a54c4");
            public static readonly Guid GetUsedToIt = new Guid("dd6be640-af8a-4190-8d2c-d0bb3198279f");
            public static readonly Guid WeAre = new Guid("ea4afb6e-40d3-43b7-bcb3-ffea7591cc82");
            public static readonly Guid Trust = new Guid("11320d49-4294-4e52-bf32-2381dfed3ac4");
            public static readonly Guid AllInIt = new Guid("fa8b1dbc-ded8-4513-95a6-875e2d586270");
        }

        internal static class ScorpionTrackIdEnum
        {
            public static readonly Guid Survival = new Guid("88f77e10-02c2-4182-a5e6-8946a84688a9");
            public static readonly Guid Nonstop = new Guid("ed7f120f-0c7d-4bcf-a733-2b4de2a50b1b");
            public static readonly Guid Elevate = new Guid("3cb2c0a8-1e79-4d6a-9b61-0af74c533787");
            public static readonly Guid Emotionless = new Guid("f52e7de3-46d6-40cc-9e67-3d28b1dd84d9");
            public static readonly Guid GodsPlan = new Guid("1e41186e-c7b1-40ed-85c9-4e4c5b5c33b7");
            public static readonly Guid ImUpset = new Guid("0a0e4f09-16b3-44d2-a545-c3f23a6bda9e");
            public static readonly Guid EightOutOfTen = new Guid("450cb1e3-ebc1-4dcb-a5a6-3e5e5db174d8");
            public static readonly Guid MobTies = new Guid("3a1a5599-ee9e-4786-88ea-57a0edf6e977");
            public static readonly Guid CantTakeAJoke = new Guid("ad85a600-f97a-42f0-a951-40b9a4b3c993");
            public static readonly Guid SandrasRose = new Guid("64955a7c-30be-4c85-8d85-d36d487ed3d5");
            public static readonly Guid TalkUp = new Guid("b75197d8-5d56-4b1d-8a5c-1a2c8c7b73d0");
            public static readonly Guid IsThereMore = new Guid("e1e8b1f7-0a07-428e-bc1d-c08dbd5c6744");
            public static readonly Guid Peak = new Guid("2a4b28e2-7a44-4716-8247-3b03d75e27d9");
            public static readonly Guid SummerGames = new Guid("8fb522a4-80c7-4551-95e9-29b4282dc81a");
            public static readonly Guid Jaded = new Guid("d65a624a-c81b-4ed1-af0a-8b27ac872e6e");
            public static readonly Guid NiceForWhat = new Guid("f0d98d33-4c4f-4d87-9a5f-33fe7c1ab7a2");
            public static readonly Guid Finesse = new Guid("3bc4e4a4-1b6f-4a53-89fc-6e62fdd442a9");
            public static readonly Guid RatchetHappyBirthday = new Guid("c0e4e1d2-0c43-41f1-952f-788496ab6f8f");
            public static readonly Guid ThatsHowYouFeel = new Guid("55e55f39-af4d-4d45-8e9a-8e5b9daaf2e4");
            public static readonly Guid BlueTint = new Guid("a0c7644a-73b7-4b3a-b457-7e51e1f63a17");
            public static readonly Guid InMyFeelings = new Guid("71d0a71f-9e5e-4fbf-8be5-0b39a10781f2");
            public static readonly Guid DontMatterToMe = new Guid("2e8f13db-8b78-4ff1-ba08-2e47abf35127");
            public static readonly Guid AfterDark = new Guid("52a3a0db-7172-41a6-8a60-6e2533f3e5b0");
            public static readonly Guid FinalFantasy = new Guid("a0fc64ff-fa2b-4d7d-9650-3a083ebdca24");
            public static readonly Guid March14 = new Guid("d8b23e3c-f1d1-47be-82b6-77a4c5e67f35");
        }

        internal static class DivideTrackIdEnum
        {
            public static readonly Guid Eraser = new Guid("85f7c136-2ce9-4163-b01c-7beea05056a7");
            public static readonly Guid CastleontheHill = new Guid("6a5f1024-050b-432f-87cb-e9781c2da92f");
            public static readonly Guid Dive = new Guid("9154c3ac-6c9d-429c-a732-6bfe671b36fa");
            public static readonly Guid ShapeofYou = new Guid("be25d676-8cdc-4e06-9294-586a7d37ff76");
            public static readonly Guid Perfect = new Guid("a9424a75-7dd3-4ddd-98d2-d7cd55fbbfc4");
            public static readonly Guid GalwayGirl = new Guid("d41e2f9d-56a9-48a2-9003-cf0d1ecd91cb");
            public static readonly Guid Happier = new Guid("251cf78c-9b90-4d8e-bcb5-0add3b3e7030");
            public static readonly Guid NewMan = new Guid("cea1e4bf-cc0c-44d7-992c-31b81dc72d74");
            public static readonly Guid HeartsDontBreakAroundHere = new Guid("9eb5a8fa-911f-4310-901b-f50ff0bf7b39");
            public static readonly Guid WhatDoIKnow = new Guid("5ec063e4-d881-4aff-9a1d-c588255094f8");
            public static readonly Guid HowWouldYouFeelPaean = new Guid("605a8a4a-8626-4f7a-8138-86597f0382ea");
            public static readonly Guid SupermarketFlowers = new Guid("db66bffc-e43b-4721-9fb3-30083ff12e4f");
            public static readonly Guid Barcelona = new Guid("41863e97-3f34-4dab-8222-23494334fa4e");
            public static readonly Guid BibiaBeYeYe = new Guid("cf295a6b-92c8-4dd8-9044-27607055dd3c");
            public static readonly Guid NancyMulligan = new Guid("28f6e7d4-af28-48c8-8def-3bac2538cb45");
            public static readonly Guid SaveMyself = new Guid("9a782ce1-740f-4009-ade0-d474616df4b4");
        }

        internal static class SweetenerTrackIdEnum
        {
            public static readonly Guid Raindrops = new Guid("172b01ab-8169-4c04-b54e-7cbfcb8a0931");
            public static readonly Guid Blazed = new Guid("a0c8d366-0d09-4d9c-9c54-e26517e258b7");
            public static readonly Guid TheLightIsComing = new Guid("08711cd7-f5fe-47c8-9cd2-3fc5f22f93c3");
            public static readonly Guid REM = new Guid("e0cfeeaa-d871-4352-b1bb-f0a3e222d0ae");
            public static readonly Guid GodIsAWoman = new Guid("6a9090f3-4cb1-457b-8341-8d95786e2f93");
            public static readonly Guid Sweetener = new Guid("da8a67d5-ada2-47f8-8d17-7a8158e0ba79");
            public static readonly Guid Successful = new Guid("a5cc759d-14b1-4015-8593-7c47d80a4b17");
            public static readonly Guid Everytime = new Guid("1c8296c3-6bae-4036-8cf9-58ea04038866");
            public static readonly Guid Breathin = new Guid("5ec151a2-8644-4e89-923d-8003d5d4cbc1");
            public static readonly Guid NoTearsLefttoCry = new Guid("3ffcd571-109a-4732-9816-ec12eb52580e");
            public static readonly Guid Borderline = new Guid("3b44f4ed-824b-4d78-ae64-937b1e43d741");
            public static readonly Guid BetterOff = new Guid("f7ce6650-bcf4-4137-b8ac-f7c0e5bcb7cb");
            public static readonly Guid GoodnightNGo = new Guid("04a709fb-85ac-4a7b-b675-4b92f9c540da");
            public static readonly Guid PeteDavidson = new Guid("bc28acab-30c4-4cb4-9201-0958ac78c822");
            public static readonly Guid GetWellSoon = new Guid("c8dc0367-e04e-442e-bc2a-3b64c858d3cb");
        }

        internal static class _1989TrackIdEnum
        {
            public static readonly Guid WelcomeToNewYork = new Guid("342c4173-99cc-404f-82cb-e9672829926c");
            public static readonly Guid BlankSpace = new Guid("554abc99-8c15-450d-93fd-34f6cc16bf8b");
            public static readonly Guid Style = new Guid("52a6e6da-9d3e-4905-aa5e-a0745496d056");
            public static readonly Guid OutOfTheWoods = new Guid("6bf3e7d0-b9b1-475c-8cec-dcd2fb7746d3");
            public static readonly Guid AllYouHadToDoWasStay = new Guid("92efc2af-14aa-43e3-a8b3-ed5c38d76311");
            public static readonly Guid ShakeItOff = new Guid("40919dca-43b0-40fd-8d3e-f8054cfa3ef5");
            public static readonly Guid IWishYouWould = new Guid("905917ab-51b5-402a-8367-9dc3256cf1f2");
            public static readonly Guid BadBlood = new Guid("063c93e9-5785-48ab-bd62-c52ea0c654b9");
            public static readonly Guid WildestDreams = new Guid("8a2165b8-f201-421c-87ae-03642914a34b");
            public static readonly Guid HowYouGetTheGirl = new Guid("f163d0c0-99b3-4ebd-be69-716b94f7d994");
            public static readonly Guid ThisLove = new Guid("7ac102ca-5e6f-41ee-acc0-6b0e7941a9fd");
            public static readonly Guid IKnowPlaces = new Guid("32ec0969-1493-4960-97a8-32c068ad95c7");
            public static readonly Guid Clean = new Guid("d65c7a12-3a01-48c0-92b2-8a46fa0c3491");
        }

        internal static class _24KMagicTrackIdEnum
        {
            public static readonly Guid _24KMagic = new Guid("785f9d64-0f05-4aea-90f4-cbbcd7c9b946");
            public static readonly Guid Chunky = new Guid("9371a131-4d36-4b46-8d1f-82a6f4763534");
            public static readonly Guid Perm = new Guid("44eae267-b790-48d3-8304-0059c7f5652e");
            public static readonly Guid ThatsWhatILike = new Guid("3c7b9e52-2e80-427a-a4f1-4a1cf80fd412");
            public static readonly Guid VersaceOnTheFloor = new Guid("88b66b3b-b3d2-42cd-90ec-39788d0dd512");
            public static readonly Guid StraightUpAndDown = new Guid("231eb456-d1fb-4f25-a4a8-9c4c559e4c2f");
            public static readonly Guid CallingAllMyLovelies = new Guid("76a23627-35c3-4bb8-b9dc-65badf5e63f1");
            public static readonly Guid Finesse = new Guid("512a02cb-3b12-4ba4-b959-af37747ef1e9");
            public static readonly Guid TooGoodToSayGoodbye = new Guid("bf807e39-2791-4fa2-8dc3-64c145489720");
        }

        internal static class AntiTrackIdEnum
        {
            public static readonly Guid Consideration = new Guid("d540bd3c-870a-4e1b-b575-80069b4dd27b");
            public static readonly Guid JamesJoint = new Guid("9fd0c929-c39e-4d21-aaf5-9b27058637e2");
            public static readonly Guid KissItBetter = new Guid("23533d5b-5e56-46f4-a5d3-4cc138696854");
            public static readonly Guid Work = new Guid("5b6ab067-1e79-48bf-ac67-a4a478a64c15");
            public static readonly Guid Desperado = new Guid("bfe235f7-3597-4ae5-9413-e8e831b1911e");
            public static readonly Guid Woo = new Guid("d95f9b2b-bee0-4105-b0a8-680db66cd032");
            public static readonly Guid NeededMe = new Guid("10a03e67-246a-495c-8913-a1d6a9479d23");
            public static readonly Guid YeahImThOne = new Guid("a7edab83-5889-4e6a-9d2b-9a3fc504c29f");
            public static readonly Guid SameOlMistakes = new Guid("73968f68-af90-4cda-9be5-5c4cffc43dab");
            public static readonly Guid NeverEnding = new Guid("32496198-3ed2-46d6-a0ce-5403983fcbca");
            public static readonly Guid LoveOnTheBrain = new Guid("ded32561-2dda-4d56-b31b-3fd357d0c459");
            public static readonly Guid Higher = new Guid("3a67f4c9-f38f-4164-ac51-82dcf6b5bcbe");
            public static readonly Guid CloseToYou = new Guid("e9dbaa64-3eca-4ffa-b8dc-44e4fa30a620");
            public static readonly Guid GoodNightGotham = new Guid("f26435c7-9fed-4a89-b125-32cc89a4ae69");
            public static readonly Guid Pose = new Guid("f77fad81-b88d-45fa-abc7-6842b0642cca");
            public static readonly Guid SexWithMe = new Guid("d570d995-f615-42d7-9456-36a29a129d29");
        }

        internal static class DAMNTrackIdEnum
        {
            public static readonly Guid BLOOD = new Guid("d89f6658-aa9a-46ba-bef9-35538a7129b5");
            public static readonly Guid DNA = new Guid("80890b51-f7e0-4302-882b-1e60a79d2315");
            public static readonly Guid YAH = new Guid("d3c49bac-f66f-41cd-ac63-46553f9d97d4");
            public static readonly Guid ELEMENT = new Guid("5c4f6bf2-34da-43de-a5e4-860992d8cdf4");
            public static readonly Guid FEEL = new Guid("9b5b7d9e-10aa-4aa0-b08c-b8d2779ccdb9");
            public static readonly Guid LOYALTY = new Guid("36584c54-91b8-42fb-af1d-19025d24c68c");
            public static readonly Guid PRIDE = new Guid("0dc97df0-976b-4816-be51-a2f491027c1a");
            public static readonly Guid HUMBLE = new Guid("08613aac-be0b-48f2-ae01-c33bc68b12fe");
            public static readonly Guid LUST = new Guid("a9620719-90e7-41b1-9517-4ecc81693c73");
            public static readonly Guid LOVE = new Guid("38e68a81-9342-4cd5-ae18-b0e08b92a9c6");
            public static readonly Guid XXX = new Guid("6cd2e038-f910-471b-93dc-94d636675584");
            public static readonly Guid FEAR = new Guid("f90d17eb-8e83-4218-bdfd-807861a8e77a");
            public static readonly Guid GOD = new Guid("384e9aee-60f8-43ac-8c32-9ce084bf2003");
            public static readonly Guid DUCKWORTH = new Guid("f25a4e62-4663-4aa4-a3f5-c2bc06af9b23");
        }
    }
}
