using Tibia.Addresses;

namespace Tibia
{
    public partial class Version
    {
        public static void SetVersion862()
        {
            BattleList.Start = 0x637CE0;
            BattleList.StepCreatures = 0xA8;
            BattleList.MaxCreatures = 1300;
            BattleList.End = BattleList.Start + (BattleList.StepCreatures * BattleList.MaxCreatures);

            Client.StartTime = 0x8034E8;
            Client.XTeaKey = 0x7BC6E4;
            Client.SocketStruct = 0x7BC6B8;
            Client.RecvPointer = 0x5B25E4;
            Client.SendPointer = 0x5B2610;
            Client.FrameRatePointer = 0x7C07CC;
            Client.FrameRateCurrentOffset = 0x60;
            Client.FrameRateLimitOffset = 0x58;
            Client.MultiClient = 0x5079B4;
            Client.Status = 0x7BFC84;
            Client.SafeMode = 0x7BCB0C;
            Client.FollowMode = Client.SafeMode + 4;
            Client.AttackMode = Client.FollowMode + 4;
            Client.ActionState = 0x7BFCE4;
            Client.ActionStateFreezer = 0x518F90;
            Client.LastMSGText = 0x789CF8;
            Client.LastMSGAuthor = Client.LastMSGText - 0x28;
            Client.StatusbarText = 0x803508;
            Client.StatusbarTime = Client.StatusbarText - 4;
            Client.ClickId = 0x7BFD24;
            Client.ClickCount = Client.ClickId + 4;
            Client.ClickZ = Client.ClickId - 0x68;
            Client.SeeId = Client.ClickId + 12;
            Client.SeeCount = Client.SeeId + 4;
            Client.SeeZ = Client.SeeId - 0x68;
            Client.ClickContextMenuItemId = 0x7BFD30;
            Client.ClickContextMenuCreatureId = 0x7BFD34;
            Client.LoginServerStart = 0x7B7620;
            Client.StepLoginServer = 112;
            Client.DistancePort = 100;
            Client.MaxLoginServers = 10;
            Client.RSA = 0x5B2980;
            Client.LoginCharList = 0x7BFC38;
            Client.LoginCharListLength = 0x7BFC3C;
            Client.LoginSelectedChar = 0x7BFC34;
            Client.GameWindowRectPointer = 0x66F080;
            Client.GameWindowBar = 0x8034F8;
            Client.DatPointer = 0x7BC704;
            Client.EventTriggerPointer = 0x51AA90;
            Client.DialogPointer = 0x6723EC;
            Client.DialogLeft = 0x14;
            Client.DialogTop = 0x18;
            Client.DialogWidth = 0x1C;
            Client.DialogHeight = 0x20;
            Client.DialogCaption = 0x50;
            Client.LastRcvPacket = 0x7B7E98;
            Client.DecryptCall = 0x45A775;
            Client.LoginAccountNum = 0;
            Client.LoginPassword = 0x7BFC40;
            Client.LoginAccount = Client.LoginPassword + 32;
            Client.LoginPatch = 0;
            Client.LoginPatch2 = 0;
            Client.LoginPatchOrig = new byte[] { 0xE8, 0x0D, 0x1D, 0x09, 0x00 };
            Client.LoginPatchOrig2 = new byte[] { 0xE8, 0xC8, 0x15, 0x09, 0x00 };
            Client.ParserFunc = 0x45A740;
            Client.GetNextPacketCall = 0x45A775;
            Client.RecvStream = 0x7BC6D4;

            Container.Start = 0x66FB38;
            Container.StepContainer = 492;
            Container.StepSlot = 12;
            Container.MaxContainers = 16;
            Container.MaxStack = 100;
            Container.DistanceIsOpen = 0;
            Container.DistanceId = 4;
            Container.DistanceName = 16;
            Container.DistanceVolume = 48;
            Container.DistanceAmount = 56;
            Container.DistanceItemId = 60;
            Container.DistanceItemCount = 64;
            Container.End = Container.Start + (Container.MaxContainers * Container.StepContainer);

            ContextMenus.AddContextMenuPtr = 0x450C90;
            ContextMenus.OnClickContextMenuPtr = 0x44D870;
            ContextMenus.OnClickContextMenuVf = 0x5B7878;
            ContextMenus.AddSetOutfitContextMenu = 0x451BAC;
            ContextMenus.AddPartyActionContextMenu = 0x451AD4;
            ContextMenus.AddCopyNameContextMenu = 0x451C14;
            ContextMenus.AddTradeWithContextMenu = 0x451839;
            ContextMenus.AddLookContextMenu = 0x4516EF;

            Creature.DistanceId = 0;
            Creature.DistanceType = 3;
            Creature.DistanceName = 4;
            Creature.DistanceX = 36;
            Creature.DistanceY = 40;
            Creature.DistanceZ = 44;
            Creature.DistanceScreenOffsetHoriz = 48;
            Creature.DistanceScreenOffsetVert = 52;
            Creature.DistanceIsWalking = 76;
            Creature.DistanceWalkSpeed = 140;
            Creature.DistanceDirection = 80;
            Creature.DistanceIsVisible = 144;
            Creature.DistanceBlackSquare = 132;
            Creature.DistanceLight = 120;
            Creature.DistanceLightColor = 124;
            Creature.DistanceHPBar = 136;
            Creature.DistanceSkull = 148;
            Creature.DistanceParty = 152;
            Creature.DistanceWarIcon = 160;
            Creature.DistanceIsBlocking = 164;
            Creature.DistanceOutfit = 96;
            Creature.DistanceColorHead = 100;
            Creature.DistanceColorBody = 104;
            Creature.DistanceColorLegs = 108;
            Creature.DistanceColorFeet = 112;
            Creature.DistanceAddon = 116;

            DatItem.StepItems = 0x4C;
            DatItem.Width = 0;
            DatItem.Height = 4;
            DatItem.MaxSizeInPixels = 8;
            DatItem.Layers = 12;
            DatItem.PatternX = 16;
            DatItem.PatternY = 20;
            DatItem.PatternDepth = 24;
            DatItem.Phase = 28;
            DatItem.Sprite = 32;
            DatItem.Flags = 36;
            DatItem.CanLookAt = 0;
            DatItem.WalkSpeed = 40;
            DatItem.TextLimit = 44;
            DatItem.LightRadius = 48;
            DatItem.LightColor = 52;
            DatItem.ShiftX = 56;
            DatItem.ShiftY = 60;
            DatItem.WalkHeight = 64;
            DatItem.Automap = 68;
            DatItem.LensHelp = 72;

            DrawItem.DrawItemFunc = 0x4B1B30;

            DrawSkin.DrawSkinFunc = 0x4B57A0;

            Hotkey.SendAutomaticallyStart = 0x7BCD08;
            Hotkey.SendAutomaticallyStep = 0x01;
            Hotkey.TextStart = 0x7BCD30;
            Hotkey.TextStep = 0x100;
            Hotkey.ObjectStart = 0x7BCC78;
            Hotkey.ObjectStep = 0x04;
            Hotkey.ObjectUseTypeStart = 0x7BCB58;
            Hotkey.ObjectUseTypeStep = 0x04;
            Hotkey.MaxHotkeys = 36;

            Map.MapPointer = 0x676F40;
            Map.StepTile = 168;
            Map.StepTileObject = 12;
            Map.DistanceTileObjectCount = 0;
            Map.DistanceTileObjects = 4;
            Map.DistanceObjectId = 0;
            Map.DistanceObjectData = 4;
            Map.DistanceObjectDataEx = 8;
            Map.MaxTileObjects = 10;
            Map.MaxX = 18;
            Map.MaxY = 14;
            Map.MaxZ = 8;
            Map.MaxTiles = 2016;
            Map.ZAxisDefault = 7;
            Map.NameSpy1 = 0x4EE519;
            Map.NameSpy2 = 0x4EE523;
            Map.NameSpy1Default = 0x4C75;
            Map.NameSpy2Default = 0x4275;
            Map.LevelSpy1 = 0x4F038A;
            Map.LevelSpy2 = 0x4F048F;
            Map.LevelSpy3 = 0x4F0510;
            Map.LevelSpyPtr = 0x66F080;
            Map.LevelSpyAdd1 = 28;
            Map.LevelSpyAdd2 = 0x5BC0;
            Map.FullLightNop = 0x4E6C29;
            Map.FullLightAdr = 0x4E6C2C;
            Map.FullLightNopDefault = new byte[] { 0x7E, 0x05 };
            Map.FullLightNopEdited = new byte[] { 0x90, 0x90 };
            Map.FullLightAdrDefault = 0x80;
            Map.FullLightAdrEdited = 0xFF;

            Player.Experience = 0x637C4C;
            Player.Flags = Player.Experience - 108;
            Player.Id = Player.Experience + 12;
            Player.Health = Player.Experience + 8;
            Player.HealthMax = Player.Experience + 4;
            Player.Level = Player.Experience - 4;
            Player.MagicLevel = Player.Experience - 8;
            Player.LevelPercent = Player.Experience - 12;
            Player.MagicLevelPercent = Player.Experience - 16;
            Player.Mana = Player.Experience - 20;
            Player.ManaMax = Player.Experience - 24;
            Player.Soul = Player.Experience - 28;
            Player.Stamina = Player.Experience - 32;
            Player.Capacity = Player.Experience - 36;
            Player.FistPercent = 0x637BFC;
            Player.ClubPercent = Player.FistPercent + 4;
            Player.SwordPercent = Player.FistPercent + 8;
            Player.AxePercent = Player.FistPercent + 12;
            Player.DistancePercent = Player.FistPercent + 16;
            Player.ShieldingPercent = Player.FistPercent + 20;
            Player.FishingPercent = Player.FistPercent + 24;
            Player.Fist = Player.FistPercent + 28;
            Player.Club = Player.FistPercent + 32;
            Player.Sword = Player.FistPercent + 36;
            Player.Axe = Player.FistPercent + 40;
            Player.Distance = Player.FistPercent + 44;
            Player.Shielding = Player.FistPercent + 48;
            Player.Fishing = Player.FistPercent + 52;
            Player.SlotHead = 0x66FAC0;
            Player.SlotNeck = Player.SlotHead + 12;
            Player.SlotBackpack = Player.SlotHead + 24;
            Player.SlotArmor = Player.SlotHead + 36;
            Player.SlotRight = Player.SlotHead + 48;
            Player.SlotLeft = Player.SlotHead + 60;
            Player.SlotLegs = Player.SlotHead + 72;
            Player.SlotFeet = Player.SlotHead + 84;
            Player.SlotRing = Player.SlotHead + 96;
            Player.SlotAmmo = Player.SlotHead + 108;
            Player.MaxSlots = 10;
            Player.DistanceSlotCount = 4;
            Player.CurrentTileToGo = 0x637C60;
            Player.TilesToGo = 0x637C64;
            Player.GoToX = Player.Experience + 80;
            Player.GoToY = Player.GoToX - 4;
            Player.GoToZ = Player.GoToX - 8;
            Player.RedSquare = 0x637C24;
            Player.GreenSquare = Player.RedSquare - 4;
            Player.WhiteSquare = Player.GreenSquare - 8;
            Player.AccessN = 0;
            Player.AccessS = 0;
            Player.TargetId = Player.RedSquare;
            Player.TargetBattlelistId = Player.TargetId - 8;
            Player.TargetBattlelistType = Player.TargetId - 5;
            Player.TargetType = Player.TargetId + 3;
            Player.Z = 0x672428;
            Player.AttackCount = 0x635800;
            Player.FollowCount = Player.AttackCount + 0x20;

            TextDisplay.PrintName = 0x4F14F3;
            TextDisplay.PrintFPS = 0x458778;
            TextDisplay.ShowFPS = 0x6358FC;
            TextDisplay.PrintTextFunc = 0x4B0F70;
            TextDisplay.NopFPS = 0x4586B4;

            Vip.Start = 0x635978;
            Vip.StepPlayers = 0x2C;
            Vip.MaxPlayers = 200;
            Vip.DistanceId = 0;
            Vip.DistanceName = 4;
            Vip.DistanceStatus = 34;
            Vip.DistanceIcon = 40;
            Vip.End = Vip.Start + (Vip.StepPlayers * Vip.MaxPlayers);
        }
    }
}
