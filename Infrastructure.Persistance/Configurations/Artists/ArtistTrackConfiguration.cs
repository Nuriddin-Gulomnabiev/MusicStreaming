using Domain.Entities.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Numerics;
using System.Reflection.PortableExecutable;
using static Infrastructure.Persistance.Configurations.Artists.ArtistConfiguration;
using static Infrastructure.Persistance.Configurations.Tracks.TrackConfiguration;

namespace Infrastructure.Persistance.Configurations.Artists
{
    internal class ArtistTrackConfiguration : IEntityTypeConfiguration<ArtistTrack>
    {
        public void Configure(EntityTypeBuilder<ArtistTrack> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.ArtistId).IsRequired();
            builder.Property(p => p.TrackId).IsRequired();

            builder.HasOne(p => p.Artist).WithMany(p => p.ArtistTracks).HasForeignKey(p => p.ArtistId);
            builder.HasOne(p => p.Track).WithMany(p => p.ArtistTracks).HasForeignKey(p => p.TrackId);

            builder.HasData(
            #region 17
                new ArtistTrack { TrackId = _17TrackIdEnum.TheExplanation, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("034fe159-32db-4875-9131-6426134d2743") },
                new ArtistTrack { TrackId = _17TrackIdEnum.JocelynFlores, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("062c2665-7591-4c78-82da-da9fe95f2277") },
                new ArtistTrack { TrackId = _17TrackIdEnum.DepressionObsession, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("1227371f-f8cb-409c-ae62-9a864ce52d62") },
                new ArtistTrack { TrackId = _17TrackIdEnum.EverybodyDiesInTheirNightmares, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("1d7ace2e-de9c-492a-b535-723fb24975cb") },
                new ArtistTrack { TrackId = _17TrackIdEnum.Revenge, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("38d003fd-762e-410b-b93c-3b4ef2ec39ca") },
                new ArtistTrack { TrackId = _17TrackIdEnum.SaveMe, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("960c53c2-d34a-4692-9f2b-6d6fd1015868") },
                new ArtistTrack { TrackId = _17TrackIdEnum.DeadInsideInterlude, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("983414b0-1371-4327-bd66-684afc8e3d05") },
                new ArtistTrack { TrackId = _17TrackIdEnum.FuckLove, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("d033186f-8ab5-435e-9874-5238e141b148") },
                new ArtistTrack { TrackId = _17TrackIdEnum.CarryOn, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("dc4036b5-d7ef-4788-8b33-e21b42374005") },
                new ArtistTrack { TrackId = _17TrackIdEnum.Orlando, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("dc96bf29-f981-4cfe-9777-a459d0ab69db") },
                new ArtistTrack { TrackId = _17TrackIdEnum.AyalaOutro, ArtistId = ArtistsIdEnum.XXXtentacion, Id = new Guid("de175c65-a3a6-4204-a1b2-318abe039cee") },
            #endregion
            #region Whole Lotta Red
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.Teen, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("d64157a2-9257-4e0b-80f4-20f7e45a50a1") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.NotPlaying, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("4ef8889f-7b50-44b7-87b2-783cb166f5a9") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.JumpOutTheHouse, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("11f13d23-1db2-4f64-bb43-4dc5674f9c0e") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.NewN3on, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("18741c3f-fd9e-4b7f-876a-1e4eb6ff0ed0") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.Slay3r, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("27fdca20-7677-44e3-b92b-2c4b0e7c2a88") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.Die4Guy, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("0e4b9f71-0d6e-4414-9dc9-3c1327a5b5d6") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.Place, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("74d6b61c-58af-4503-8edf-4c2b80ad84c9") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.Metamorphosis, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("e34d2f2a-9f75-49e7-b0d9-128e0e4b7d4a") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.Control, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("c3e5bdc0-8a85-4013-9a7b-8e119a0fcb5a") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.AtMEH, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("02db298d-ee20-4b81-a8f9-26cbb0b259b9") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.F33lLik3Dyin, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("8b4c8223-5e6b-4e35-a3e1-8255797fd649") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.Over, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("d1ee8e53-2982-4d95-8728-23b13cbdd8c7") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.KingVamp, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("abf1ef6b-cf5e-4fb5-8f1e-22a8ab7b6c0d") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.MoneyAndDrugs, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("0e9c4c45-0a19-4d44-a271-637a809755e3") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.OnThatTime, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("a7e6dd5f-d654-45ef-8f29-ccbc6c91e0a1") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.Beno, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("c0802ea6-d526-4fc2-a3b4-09f14b6706fc") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.VampAnthem, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("7f576d25-73da-44af-8f3e-8bb7e8d8f605") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.Go2DaMoon, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("cf6406db-f369-485c-aece-2bba9fc9c9be") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.ILoveUIHateU, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("71b7b68b-5631-416f-a43f-29a972ff82fd") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.RockstarMade, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("89a6cc4c-640c-4f4c-951b-10bbce402939") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.PunkMonk, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("bc9bdc36-1d53-4fae-8d6e-60edf292c3f4") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.Sky, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("3567e2e1-5a2b-4d3a-8497-208bf28843de") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.StopBreathing, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("7b8b6ab2-14b0-421f-bd9e-2da8c2407d9a") },
                new ArtistTrack { TrackId = WholeLottaRedTrackIdEnum.NewTank, ArtistId = ArtistsIdEnum.PlayboiCarti, Id = new Guid("3b0d81da-0a1b-4a48-8df7-0b90a12284a9") },
            #endregion
            #region Red & White
                new ArtistTrack { TrackId = RedWhiteTrackIdEnum.SpaceCadet, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("d1c9e7c7-ee5e-4ae7-8d5e-bdb94e10bcb9") },
                new ArtistTrack { TrackId = RedWhiteTrackIdEnum.IKnow, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("6d5e3a81-520f-4ff7-9ad9-b06d72c3cfd1") },
                new ArtistTrack { TrackId = RedWhiteTrackIdEnum.FlexUp, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("d2ff6526-18be-4bb3-ba95-30361f7a2f4c") },
                new ArtistTrack { TrackId = RedWhiteTrackIdEnum.HittinMyShoulder, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("58660e66-4d3d-43cc-82c1-f10a8ce1569d") },
                new ArtistTrack { TrackId = RedWhiteTrackIdEnum.Cigarette, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("e7ce46f6-9b70-4a8e-9a0d-556536cd7832") },
                new ArtistTrack { TrackId = RedWhiteTrackIdEnum.ForFun, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("0f23192e-3d29-4d7b-bfc4-6cc7e8a1333e") },
                new ArtistTrack { TrackId = RedWhiteTrackIdEnum.BelieveMe, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("0c1081be-1b2a-45d1-80fd-f2c6d1a58d77") },
                new ArtistTrack { TrackId = RedWhiteTrackIdEnum.IssaHit, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("5ff4e98e-87a1-4a37-85ab-520b76be11da") },
                new ArtistTrack { TrackId = RedWhiteTrackIdEnum.GlockInMyPurse, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("c3e8c3a0-4db3-4f0c-83f9-32b499285a0a") },
                new ArtistTrack { TrackId = RedWhiteTrackIdEnum.FinalFantasy, ArtistId = ArtistsIdEnum.LilUziVert, Id = new Guid("3c478396-1b97-491e-8d2c-4e53fe66a426") },
            #endregion
            #region Scorpion
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.Survival, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("159625cc-83fc-496c-997f-5f8e9ba95382") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.Nonstop, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("0e9c766e-3711-487b-8f63-5b1a70179ecb") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.Elevate, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("cc6db5e7-8b8a-4dad-bb54-cf2b13ad1612") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.Emotionless, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("55b1fefa-8770-4a1d-83cf-d5279a6f4628") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.GodsPlan, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("d9e1b86b-085e-4502-b591-13393b168dd7") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.ImUpset, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("51ec7c53-4fc9-4069-a689-1e26eef9f419") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.EightOutOfTen, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("917b0066-962f-41c5-8613-ca7142805c4a") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.MobTies, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("d16be991-6408-486e-8f3b-75465cc0ae45") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.CantTakeAJoke, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("75c9c365-0988-4944-857d-5d3c27a72869") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.SandrasRose, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("3922fa95-491e-403c-a782-1895aafde570") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.TalkUp, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("3df3ab31-c120-4689-b463-446c56f6dae9") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.IsThereMore, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("76dec0a0-393c-43aa-81d5-2c6683dcfef2") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.Peak, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("6c1fa1fb-fb9d-4e13-ac53-23988ffd0456") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.SummerGames, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("36087572-27b9-4526-b77e-9eb5ffaa804d") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.Jaded, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("87da9d0b-c5b6-47ee-b6f1-1a8a3a165cfc") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.NiceForWhat, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("04bd658f-c26d-421d-9a8e-13e8893fb144") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.Finesse, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("31278f5b-7547-4943-8055-86cb35bb58b2") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.RatchetHappyBirthday, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("7d50e2cc-a8bf-457b-b24d-cf8e62df4b18") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.ThatsHowYouFeel, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("f1c5c0a0-d2ab-4f1f-81bc-c9f19a459105") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.BlueTint, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("012e5480-d34a-4072-962a-374bb02dd167") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.InMyFeelings, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("264ce9f9-14d1-4552-9b8c-459d1c6f3c24") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.DontMatterToMe, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("3dd99d1e-e0f6-416e-b82d-60532b3c2546") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.AfterDark, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("1c0e4feb-1326-4d36-9ab5-cc492259f4a5") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.FinalFantasy, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("dfcbe1df-6bbb-4741-9c2a-08e53d8056ee") },
                new ArtistTrack { TrackId = ScorpionTrackIdEnum.March14, ArtistId = ArtistsIdEnum.Drake, Id = new Guid("2626581d-14b3-48ca-a802-35d305acc305") },
            #endregion
            #region LOP5
                new ArtistTrack { TrackId = LOP5TrackIdEnum._4U, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("c878736d-da07-4401-ab27-2743d4e035c5") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.LOP5Intro, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("51b5fb42-0cf9-47c8-8e59-f6fe4175fe19") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.SwitchingLanes, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("fd03453b-e8ec-4ba0-a4ea-33cea45c6a05") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.HULU, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("6bb1b311-0d9e-449c-ad4c-d18ac8a1d72d") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.Couch, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("1683c9f0-380f-45da-ad21-42e61a58e3c8") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum._42, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.Biology101, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("baace2ca-c2c0-4cee-b129-53079d696059") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.YNS, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.Sossboy2, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("6d342342-ea26-40f4-aa92-420f3a943603") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.Practice, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum._40Clip, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.Retroville, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.DrunkAndNasty, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("ede1078f-0b6a-48d6-9822-b6d08a881cbb") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.Amen, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("0b9350a2-5db7-4215-8e3e-8f87e40e3527") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.Groceries, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("df7520f7-0f08-43e2-8c0c-bf71e2a1b9bb") },
                new ArtistTrack { TrackId = LOP5TrackIdEnum.Butterfly, ArtistId = ArtistsIdEnum.PierreBourne, Id = new Guid("cd1b577a-b8e4-4f06-bde2-942b5ef09f92") },
                #endregion
            #region _1989
                new ArtistTrack { TrackId = _1989TrackIdEnum.WelcomeToNewYork, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("9841b6ce-c264-4edc-ad4c-31cc366c09a4") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.BlankSpace, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("68502be5-7b28-4fe8-9a71-f6cb9b816706") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.Style, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("c48ae4a3-1d3c-4487-bdfd-361f96817454") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.OutOfTheWoods, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("9f5bbfcd-4383-419d-b22a-ac704204a7ee") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.AllYouHadToDoWasStay, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("70e9455e-c256-4ea5-8e75-cf1502dd703c") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.ShakeItOff, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("a792c476-29c9-4ca5-b4a6-e4d3093a3a13") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.IWishYouWould, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("7a81609b-af37-4af8-b2ef-a4c33a25bed7") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.BadBlood, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("c84b5757-2df3-4934-b3b3-58de2e3c0044") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.WildestDreams, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("2b9f516a-1ccc-45b0-862f-6c3190545674") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.HowYouGetTheGirl, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("5d53ba14-b266-4375-af7a-99202ea4f6e4") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.ThisLove, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("5a62cb61-ac5d-4ecc-b1b9-77ba9676ecc3") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.IKnowPlaces, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("30542646-2f2a-4a85-bd79-7ea65d4ad39c") },
                new ArtistTrack { TrackId = _1989TrackIdEnum.Clean, ArtistId = ArtistsIdEnum.TaylorSwift, Id = new Guid("936ffe00-8d77-46c8-ba0e-95bbbbe16500") },
            #endregion
            #region Purpose
                new ArtistTrack { TrackId = PurposeTrackIdEnum.MarkMyWords, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("554accb2-60ca-4963-b13a-765920c11859") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.ILlShowYou, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("f6405402-785d-478e-b808-1c429fd1e8db") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.WhatDoYouMean, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("c8bf8fe9-ddfd-42c8-bda6-fddf301289a0") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.Sorry, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("2195d708-1bd7-4d91-a123-8bc12c9f1208") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.LoveYourself, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("4d5bab68-549e-4027-8e73-6322040b4e00") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.Company, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("8d029e45-dfa0-4337-9ee6-f471e2da1899") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.NoPressure, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("154a7390-0633-4759-9b61-cf3108ca0eb9") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.NoSense, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("d6b3679e-e7b1-4625-8ab7-48771c70bb7a") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.TheFeeling, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("f8a1c865-eecc-4461-82b3-efbdec7a94a8") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.LifeIsWorthLiving, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("4955190b-aa9c-46f3-8583-0bf2620888a2") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.WhereAreUNow, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("bbd494c1-0ce6-4886-bdbb-0e291f8e3a1b") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.Children, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("95de138f-0a69-426f-8f5f-dfc2181a9c5d") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.Purpose, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("94846b5a-866e-44b1-a8f2-3c424d9228f8") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.BeenYou, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("6704e0b0-7df1-4965-844a-0f38c35ac4f8") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.GetUsedToIt, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("6a9fbbd6-aba4-4e25-828f-a4120d8df2d2") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.WeAre, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("c7f40952-b113-4351-8537-01e5fd3ebae9") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.Trust, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("a658ed79-9786-4de7-9d79-af0c4bc1a51d") },
                new ArtistTrack { TrackId = PurposeTrackIdEnum.AllInIt, ArtistId = ArtistsIdEnum.JustinBieber, Id = new Guid("6d01d50b-aa37-412e-a739-e69fb3619bdc") },
            #endregion

            #region _24KMagic
                new ArtistTrack { TrackId = _24KMagicTrackIdEnum._24KMagic, ArtistId = ArtistsIdEnum.BrunoMars, Id = new Guid("fc502116-f60e-4663-b01a-5058d636d188") },
                new ArtistTrack { TrackId = _24KMagicTrackIdEnum.Chunky, ArtistId = ArtistsIdEnum.BrunoMars, Id = new Guid("abfa5816-669c-4442-a947-79dc5773cb29") },
                new ArtistTrack { TrackId = _24KMagicTrackIdEnum.Perm, ArtistId = ArtistsIdEnum.BrunoMars, Id = new Guid("1d823252-a0ce-4e57-b895-94c22a531ee5") },
                new ArtistTrack { TrackId = _24KMagicTrackIdEnum.ThatsWhatILike, ArtistId = ArtistsIdEnum.BrunoMars, Id = new Guid("c31d1ffa-7f32-426a-90e4-9f3d997c28bb") },
                new ArtistTrack { TrackId = _24KMagicTrackIdEnum.VersaceOnTheFloor, ArtistId = ArtistsIdEnum.BrunoMars, Id = new Guid("afc8be46-b8b5-4b09-b6f6-26d0678ad598") },
                new ArtistTrack { TrackId = _24KMagicTrackIdEnum.StraightUpAndDown, ArtistId = ArtistsIdEnum.BrunoMars, Id = new Guid("3affc449-05bf-4c5e-be97-699f4dc2104b") },
                new ArtistTrack { TrackId = _24KMagicTrackIdEnum.CallingAllMyLovelies, ArtistId = ArtistsIdEnum.BrunoMars, Id = new Guid("ed102289-43e3-4f09-ac77-7586d8190d36") },
                new ArtistTrack { TrackId = _24KMagicTrackIdEnum.Finesse, ArtistId = ArtistsIdEnum.BrunoMars, Id = new Guid("65791d13-67df-4acc-8f5a-eba57d4c1c76") },
                new ArtistTrack { TrackId = _24KMagicTrackIdEnum.TooGoodToSayGoodbye, ArtistId = ArtistsIdEnum.BrunoMars, Id = new Guid("96f51fb8-66b3-483e-89e0-9388730acfdb") },
            #endregion
            #region Anti
                new ArtistTrack { TrackId = AntiTrackIdEnum.Consideration, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("7c744a17-7344-4430-9536-63f4d3348063") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.JamesJoint, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("a05bda5d-7d16-47da-a6cc-c6051be6bea1") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.KissItBetter, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("732711e5-8895-44c1-b796-53e4e3269f5b") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.Work, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("0edea616-8872-4f2b-ae54-42a2381e017e") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.Desperado, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("56c53eee-e989-4f4f-8f8b-428bdae67b53") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.Woo, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("60d05c00-bb9b-4c67-ab8a-10759660fe7e") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.NeededMe, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("ee4a6bb5-5073-4507-a7fb-c4250c585deb") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.YeahImThOne, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("f6ecabb3-b4e8-4df9-8439-a629888cfc44") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.SameOlMistakes, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("facfb980-d1e8-4259-b86b-da451bfc3fe5") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.NeverEnding, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("203dc7c2-b104-4ca8-8880-b6f59d89ff6e") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.LoveOnTheBrain, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("df30f841-da2e-45b8-b0de-e20c2e77c4a5") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.Higher, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("5bbd9edb-8e03-4783-b785-ac8b0ce0ee0c") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.CloseToYou, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("00f17f0b-4a11-42e5-a273-e55dd10458b0") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.GoodNightGotham, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("d83b9ba1-b86a-4b65-9f8d-eff70b55131a") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.Pose, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("d5d8b0c0-01f8-4546-a272-dd3ba425679f") },
                new ArtistTrack { TrackId = AntiTrackIdEnum.SexWithMe, ArtistId = ArtistsIdEnum.Rihanna, Id = new Guid("bdb42fee-edc1-4a9e-a1dc-e752fc8c77ac") },
            #endregion
            #region DAMN
                new ArtistTrack { TrackId = DAMNTrackIdEnum.BLOOD, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("a09b3437-7569-4a89-8a13-219a1efae6d7") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.DNA, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("55dd2f1c-ed65-46b1-b111-34fd7cf218ee") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.YAH, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("3daab4ce-b61c-44e4-ac22-d9a635f6c522") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.ELEMENT, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("1c4df7ed-1e52-4d80-b0b7-28407d57346b") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.FEEL, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("1270b1a2-6497-4aa6-98a6-f8dbc425a5c9") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.LOYALTY, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("730e65eb-ce68-45ed-84f0-6b269112966d") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.PRIDE, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("c1008ac3-0ddc-47ae-8689-6657dfce1b01") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.HUMBLE, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("d2f374a2-4e2b-44b8-95d5-c6af85ee2d2c") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.LUST, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("7ab40740-74df-4352-a95e-691246eb222f") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.LOVE, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("c87d15f6-02ce-4101-8b3e-cfb30ff03969") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.XXX, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("9c6a4902-3561-4ffd-8dd8-f02eac939b12") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.FEAR, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("41c480e7-fb14-4ee5-835c-4e11257307fb") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.GOD, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("23aaa60c-85cf-4c20-aebb-77a6c520d189") },
                new ArtistTrack { TrackId = DAMNTrackIdEnum.DUCKWORTH, ArtistId = ArtistsIdEnum.KendrickLamar, Id = new Guid("266ac634-b69a-4f23-aab5-8038b126e99f") },
            #endregion
            #region WhenWeAllFallAsleep
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.exclamationMark, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("11816d03-0ca0-4255-8588-c1325226971c") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.badguy, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("a84ee843-332e-4b5e-a2b9-d92767d1c1f9") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.xanny, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("71ee88f0-7b48-496e-953a-1955b56a66b7") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.youshouldseemeinacrown, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("93c36e8a-144d-4ac9-a013-3037e633b18b") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.allthegoodgirlsgotohell, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("97ff69a0-9113-4e22-8365-c67c8764cf22") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.wishyouweregay, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("a402d9a5-424c-4759-a6c8-563b94cc3664") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.whenthepartysover, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("f39ba472-ebfe-4f7b-a08e-7e44de763a8d") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum._8, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("35a4b0be-a32d-403c-b28b-85c20931f93e") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.mystrangeaddiction, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("85bb99aa-9d9b-4e3a-97b2-8fb97b6137ed") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.buryafriend, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("a09065d0-2be8-4094-a267-526738597853") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.ilomilo, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("572a5449-c3ce-424e-9eb5-63e67b998e5b") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.listenbeforeigo, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("8e449ac4-29ae-46a5-b9a0-87992593185e") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.iloveyou, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("3af96a6f-0c76-4e59-91c7-163d2a01561d") },
                new ArtistTrack { TrackId = WhenWeAllFallAsleepTrackIdEnum.goodbye, ArtistId = ArtistsIdEnum.BillieEilish, Id = new Guid("dece33fd-e1e8-430f-b72c-fb5d9aa50c92") },
            #endregion

            #region Sweetener
    new ArtistTrack { TrackId = SweetenerTrackIdEnum.Raindrops, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("703d7b78-5d99-49f1-9e73-7acb8459b1d9") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.Blazed, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("eb86cede-29fd-4d70-8311-2952819337db") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.TheLightIsComing, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("070bad5c-b58a-4d0a-8090-8ce1e30eb1d5") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.REM, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("2b26decc-5803-4087-a94a-39f6754f5b44") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.GodIsAWoman, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("35242a23-4871-465f-81a5-2168942f0a1a") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.Sweetener, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("95bd8cb1-02ea-40eb-bf89-3bb4813543b4") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.Successful, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("68a89cf0-6649-42f1-a422-012bf51bc2f4") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.Everytime, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("59470b2d-49c5-44ee-a07b-2393c10b041e") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.Breathin, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("628d31d2-a8a0-4adb-b611-0d052b1c7af7") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.NoTearsLefttoCry, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("99f4e048-be2e-4702-bbd0-d5ca7034eb1b") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.Borderline, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("e73709de-84a4-4fa1-8425-4e9a35519772") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.BetterOff, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("37e84066-80b3-4909-ab33-35271de46a6b") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.GoodnightNGo, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("65b036dc-635e-4e32-8b29-28d7b51b9732") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.PeteDavidson, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("65e79682-87a8-42e2-8b33-6e54cd0341c4") },
                new ArtistTrack { TrackId = SweetenerTrackIdEnum.GetWellSoon, ArtistId = ArtistsIdEnum.ArianaGrande, Id = new Guid("400e8bc6-5bf3-40c6-ac6d-96828a975544") },
            #endregion
            #region Divide
                new ArtistTrack { TrackId = DivideTrackIdEnum.Eraser, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("10bf0cb5-32b8-4302-84bc-f6d738ec51ee") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.CastleontheHill, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("435f5d12-6f61-4483-8063-1e763b677fb4") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.Dive, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("2f0ce2f3-dac2-4c64-b685-4541938f0648") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.ShapeofYou, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("60e6c661-a7af-43dd-bdc9-01894f11f3da") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.Perfect, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("4bb062c5-c7c6-413d-aadb-abf17818e620") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.GalwayGirl, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("6aeabfef-0467-4428-9f8b-8069e95f6c77") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.Happier, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("4b5de087-d859-4eae-96d3-267b2bbbb93e") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.NewMan, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("aee5ac47-c514-422c-ad07-977cc91d33cc") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.HeartsDontBreakAroundHere, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("c079d25c-ce0a-4f49-89f8-1e054852506c") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.WhatDoIKnow, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("23a980c1-08c2-4208-a5fe-093243f8a8c1") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.HowWouldYouFeelPaean, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("1356c868-10d8-41b8-8b19-f0615a6b3867") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.SupermarketFlowers, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("c9215357-9122-4fa2-9c38-0eb275849f8a") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.Barcelona, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("9ae984d3-af4c-43bb-9a44-c08baecbccba") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.BibiaBeYeYe, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("dcd3027f-309e-4f11-906b-0b194351e0ce") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.NancyMulligan, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("f80e4383-e550-4e30-8fb4-591ca146f31b") },
                new ArtistTrack { TrackId = DivideTrackIdEnum.SaveMyself, ArtistId = ArtistsIdEnum.EdSheeran, Id = new Guid("9da2d1f5-a83f-499a-b6f9-9abdbffc54bb") }
                #endregion
            );
        }
    }
}
