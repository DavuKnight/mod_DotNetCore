using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerothServiceBusContracts.ServiceBusEvents
{
    public static class PlayerEvents
    {
        public const string OnPlayerReleasedGhost = "PlayerEvents.OnPlayerReleasedGhost";
        public const string OnSendInitialPacketsBeforeAddToMap = "PlayerEvents.OnSendInitialPacketsBeforeAddToMap";
        public const string OnBattlegroundDesertion = "PlayerEvents.OnBattlegroundDesertion";
        public const string OnPlayerCompleteQuest = "PlayerEvents.OnPlayerCompleteQuest";
        public const string OnPVPKill = "PlayerEvents.OnPVPKill";
        public const string OnPlayerPVPFlagChange = "PlayerEvents.OnPlayerPVPFlagChange";
        public const string OnCreatureKill = "PlayerEvents.OnCreatureKill";
        public const string OnCreatureKilledByPet = "PlayerEvents.OnCreatureKilledByPet";
        public const string OnPlayerKilledByCreature = "PlayerEvents.OnPlayerKilledByCreature";
        public const string OnLevelChanged = "PlayerEvents.OnLevelChanged";
        public const string OnFreeTalentPointsChanged = "PlayerEvents.OnFreeTalentPointsChanged";
        public const string OnTalentsReset = "PlayerEvents.OnTalentsReset";
        public const string OnBeforeUpdate = "PlayerEvents.OnBeforeUpdate";
        public const string OnUpdate = "PlayerEvents.OnUpdate";
        public const string OnMoneyChanged = "PlayerEvents.OnMoneyChanged";
        public const string OnGiveXP = "PlayerEvents.OnGiveXP";
        public const string OnReputationChange = "PlayerEvents.OnReputationChange";
        public const string OnReputationRankChange = "PlayerEvents.OnReputationRankChange";
        public const string OnLearnSpell = "PlayerEvents.OnLearnSpell";
        public const string OnForgotSpell = "PlayerEvents.OnForgotSpell";
        public const string OnDuelRequest = "PlayerEvents.OnDuelRequest";
        public const string OnDuelStart = "PlayerEvents.OnDuelStart";
        public const string OnDuelEnd = "PlayerEvents.OnDuelEnd";
        public const string OnChat = "PlayerEvents.OnChat";
        public const string OnBeforeSendChatMessage = "PlayerEvents.OnBeforeSendChatMessage";
        public const string OnGroupChat = "PlayerEvents.OnGroupChat";
        public const string OnPlayerChat = "PlayerEvents.OnPlayerChat";
        public const string OnGuildChat = "PlayerEvents.OnGuildChat";
        public const string OnChannelChat = "PlayerEvents.OnChannelChat";
        public const string OnEmote = "PlayerEvents.OnEmote";//OnTextEmoteOverload
        public const string OnTextEmote = "PlayerEvents.OnTextEmote";
        public const string OnSpellCast = "PlayerEvents.OnSpellCast";
        public const string OnLoadFromDB = "PlayerEvents.OnLoadFromDB";
        public const string OnLogin = "PlayerEvents.OnLogin";
        public const string OnLogout = "PlayerEvents.OnLogout";
        public const string OnCreate = "PlayerEvents.OnCreate";
        public const string OnDelete = "PlayerEvents.OnDelete";
        public const string OnFailedDelete = "PlayerEvents.OnFailedDelete";
        public const string OnSave = "PlayerEvents.OnSave";
        public const string OnBindToInstance = "PlayerEvents.OnBindToInstance";
        public const string OnUpdateZone = "PlayerEvents.OnUpdateZone";
        public const string OnUpdateArea = "PlayerEvents.OnUpdateArea";
        public const string OnMapChanged = "PlayerEvents.OnMapChanged";
        public const string OnBeforeTeleport = "PlayerEvents.OnBeforeTeleport";
        public const string OnUpdateFaction = "PlayerEvents.OnUpdateFaction";
        public const string OnAddToBattleground = "PlayerEvents.OnAddToBattleground";
        public const string OnQueueRandomDungeon = "PlayerEvents.OnQueueRandomDungeon";
        public const string OnRemoveFromBattleground = "PlayerEvents.OnRemoveFromBattleground";
        public const string OnAchiComplete = "PlayerEvents.OnAchiComplete";
        public const string OnBeforeAchiComplete = "PlayerEvents.OnBeforeAchiComplete";
        public const string OnCriteriaProgress = "PlayerEvents.OnCriteriaProgress";
        public const string OnBeforeCriteriaProgress = "PlayerEvents.OnBeforeCriteriaProgress";
        public const string OnAchiSave = "PlayerEvents.OnAchiSave";
        public const string OnCriteriaSave = "PlayerEvents.OnCriteriaSave";
        public const string OnGossipSelect = "PlayerEvents.OnGossipSelect";
        public const string OnGossipSelectCode = "PlayerEvents.OnGossipSelectCode";
        public const string OnBeingCharmed = "PlayerEvents.OnBeingCharmed";
        public const string OnAfterSetVisibleItemSlot = "PlayerEvents.OnAfterSetVisibleItemSlot";
        public const string OnAfterMoveItemFromInventory = "PlayerEvents.OnAfterMoveItemFromInventory";
        public const string OnEquip = "PlayerEvents.OnEquip";
        public const string OnPlayerJoinBG = "PlayerEvents.OnPlayerJoinBG";
        public const string OnPlayerJoinArena = "PlayerEvents.OnPlayerJoinArena";
        public const string GetCustomGetArenaTeamId = "PlayerEvents.GetCustomGetArenaTeamId";
        public const string GetCustomArenaPersonalRating = "PlayerEvents.GetCustomArenaPersonalRating";
        public const string OnGetMaxPersonalArenaRatingRequirement = "PlayerEvents.OnGetMaxPersonalArenaRatingRequirement";
        public const string OnLootItem = "PlayerEvents.OnLootItem";
        public const string OnCreateItem = "PlayerEvents.OnCreateItem";
        public const string OnQuestRewardItem = "PlayerEvents.OnQuestRewardItem";
        public const string OnGroupRollRewardItem = "PlayerEvents.OnGroupRollRewardItem";
        public const string OnBeforeQuestComplete = "PlayerEvents.OnBeforeQuestComplete";
        public const string OnQuestComputeXP = "PlayerEvents.OnQuestComputeXP";
        public const string OnBeforeDurabilityRepair = "PlayerEvents.OnBeforeDurabilityRepair";
        public const string OnBeforeBuyItemFromVendor = "PlayerEvents.OnBeforeBuyItemFromVendor";
        public const string OnBeforeStoreOrEquipNewItem = "PlayerEvents.OnBeforeStoreOrEquipNewItem";
        public const string OnAfterStoreOrEquipNewItem = "PlayerEvents.OnAfterStoreOrEquipNewItem";
        public const string OnAfterUpdateMaxPower = "PlayerEvents.OnAfterUpdateMaxPower";
        public const string OnAfterUpdateMaxHealth = "PlayerEvents.OnAfterUpdateMaxHealth";
        public const string OnBeforeUpdateAttackPowerAndDamage = "PlayerEvents.OnBeforeUpdateAttackPowerAndDamage";
        public const string OnAfterUpdateAttackPowerAndDamage = "PlayerEvents.OnAfterUpdateAttackPowerAndDamage";
        public const string OnBeforeInitTalentForLevel = "PlayerEvents.OnBeforeInitTalentForLevel";
        public const string OnFirstLogin = "PlayerEvents.OnFirstLogin";
        public const string ShouldBeRewardedWithMoneyInsteadOfExp = "PlayerEvents.ShouldBeRewardedWithMoneyInsteadOfExp";
        public const string OnBeforeTempSummonInitStats = "PlayerEvents.OnBeforeTempSummonInitStats";
        public const string OnBeforeGuardianInitStatsForLevel = "PlayerEvents.OnBeforeGuardianInitStatsForLevel";
        public const string OnAfterGuardianInitStatsForLevel = "PlayerEvents.OnAfterGuardianInitStatsForLevel";
        public const string OnSendInitialPacketsBeOnBeforeLoadPetFromDBforeAddToMap = "PlayerEvents.OnBeforeLoadPetFromDB";
        public const string CanJoinInArenaQueue = "PlayerEvents.CanJoinInArenaQueue";
        public const string CanBattleFieldPort = "PlayerEvents.CanBattleFieldPort";
        public const string CanGroupInvite = "PlayerEvents.CanGroupInvite";
        public const string CanGroupAccept = "PlayerEvents.CanGroupAccept";
        public const string CanSellItem = "PlayerEvents.CanSellItem";
        public const string CanSendMail = "PlayerEvents.CanSendMail";
        public const string PetitionBuy = "PlayerEvents.PetitionBuy";
        public const string PetitionShowList = "PlayerEvents.PetitionShowList";
        public const string OnRewardKillRewarder = "PlayerEvents.OnRewardKillRewarder";
        public const string CanGiveMailRewardAtGiveLevel = "PlayerEvents.CanGiveMailRewardAtGiveLevel";
        public const string OnDeleteFromDB = "PlayerEvents.OnDeleteFromDB";
        public const string CanRepopAtGraveyard = "PlayerEvents.CanRepopAtGraveyard";
        public const string OnGetMaxSkillValue = "PlayerEvents.OnGetMaxSkillValue";
        public const string CanAreaExploreAndOutdoor = "PlayerEvents.CanAreaExploreAndOutdoor";
        public const string OnVictimRewardBefore = "PlayerEvents.OnVictimRewardBefore";
        public const string OnVictimRewardAfter = "PlayerEvents.OnVictimRewardAfter";
        public const string OnCustomScalingStatValueBefore = "PlayerEvents.OnCustomScalingStatValueBefore";
        public const string OnCustomScalingStatValue = "PlayerEvents.OnCustomScalingStatValue";
        public const string CanArmorDamageModifier = "PlayerEvents.CanArmorDamageModifier";
        public const string OnGetFeralApBonus = "PlayerEvents.OnGetFeralApBonus";
        public const string CanApplyWeaponDependentAuraDamageMod = "PlayerEvents.CanApplyWeaponDependentAuraDamageMod";
        public const string CanApplyEquipSpell = "PlayerEvents.CanApplyEquipSpell";
        public const string CanApplyEquipSpellsItemSet = "PlayerEvents.CanApplyEquipSpellsItemSet";
        public const string CanCastItemCombatSpell = "PlayerEvents.CanCastItemCombatSpell";
        public const string CanCastItemUseSpell = "PlayerEvents.CanCastItemUseSpell";
        public const string OnApplyAmmoBonuses = "PlayerEvents.OnApplyAmmoBonuses";
        public const string CanEquipItem = "PlayerEvents.CanEquipItem";
        public const string CanUnequipItem = "PlayerEvents.CanUnequipItem";
        public const string CanUseItem = "PlayerEvents.CanUseItem";
        public const string CanSaveEquipNewItem = "PlayerEvents.CanSaveEquipNewItem";
        public const string CanApplyEnchantment = "PlayerEvents.CanApplyEnchantment";
        public const string OnGetQuestRate = "PlayerEvents.OnGetQuestRate";
        public const string PassedQuestKilledMonsterCredit = "PlayerEvents.PassedQuestKilledMonsterCredit";
        public const string CheckItemInSlotAtLoadInventory = "PlayerEvents.CheckItemInSlotAtLoadInventory";
        public const string NotAvoidSatisfy = "PlayerEvents.NotAvoidSatisfy";
        public const string NotVisibleGloballyFor = "PlayerEvents.NotVisibleGloballyFor";
        public const string OnGetArenaPersonalRating = "PlayerEvents.OnGetArenaPersonalRating";
        public const string OnGetArenaTeamId = "PlayerEvents.OnGetArenaTeamId";
        public const string OnIsFFAPvP = "PlayerEvents.OnIsFFAPvP";
        public const string OnIsPvP = "PlayerEvents.OnIsPvP";
        public const string OnGetMaxSkillValueForLevel = "PlayerEvents.OnGetMaxSkillValueForLevel";
        public const string NotSetArenaTeamInfoField = "PlayerEvents.NotSetArenaTeamInfoField";
        public const string CanJoinLfg = "PlayerEvents.CanJoinLfg";
        public const string CanEnterMap = "PlayerEvents.CanEnterMap";
        public const string CanInitTrade = "PlayerEvents.CanInitTrade";
        public const string OnSetServerSideVisibility = "PlayerEvents.OnSetServerSideVisibility";
        public const string OnSetServerSideVisibilityDetect = "PlayerEvents.OnSetServerSideVisibilityDetect";
        public const string OnPlayerResurrect = "PlayerEvents.OnPlayerResurrect";
        public const string CanPlayerUseDefaultChat = "PlayerEvents.CanPlayerUseDefaultChat";
        public const string CanPlayerUsePrivateChat = "PlayerEvents.CanPlayerUsePrivateChat";
        public const string CanPlayerUseGroupChat = "PlayerEvents.CanPlayerUseGroupChat";
        public const string CanPlayerUseGuildChat = "PlayerEvents.CanPlayerUseGuildChat";
        public const string CanPlayerUseChat = "PlayerEvents.CanPlayerUseChat";
        public const string OnPlayerLearnTalents = "PlayerEvents.OnPlayerLearnTalents";
        public const string OnPlayerEnterCombat = "PlayerEvents.OnPlayerEnterCombat";
        public const string OnPlayerLeaveCombat = "PlayerEvents.OnPlayerLeaveCombat";
        public const string OnQuestAbandon = "PlayerEvents.OnQuestAbandon";
        public const string AnticheatSetSkipOnePacketForASH = "PlayerEvents.AnticheatSetSkipOnePacketForASH";
        public const string AnticheatSetCanFlybyServer = "PlayerEvents.AnticheatSetCanFlybyServer";
        public const string AnticheatSetUnderACKmount = "PlayerEvents.AnticheatSetUnderACKmount";
        public const string AnticheatSetRootACKUpd = "PlayerEvents.AnticheatSetRootACKUpd";
        public const string AnticheatSetJumpingbyOpcode = "PlayerEvents.AnticheatSetJumpingbyOpcode";
        public const string AnticheatUpdateMovementInfo = "PlayerEvents.AnticheatUpdateMovementInfo";
        public const string AnticheatHandleDoubleJump = "PlayerEvents.AnticheatHandleDoubleJump";
        public const string AnticheatCheckMovementInfo = "PlayerEvents.AnticheatCheckMovementInfo";
    }
}