using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using CyberpunkGameplayAssistant.ViewModels;
using CyberpunkGameplayAssistant.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class GameCampaign : BaseModel
    {
        // Constructors
        public GameCampaign()
        {
            InitializeLists();
            Name = "New Campaign";
            SetStartDateValues(AppData.DefaultDate);
            SetCurrentDateValues(AppData.DefaultDate);
        }

        // Databound Properties
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private Combatant _ActiveCombatant;
        public Combatant ActiveCombatant
        {
            get => _ActiveCombatant;
            set => SetAndNotify(ref _ActiveCombatant, value);
        }
        private ObservableCollection<Combatant> _AllCombatants;
        public ObservableCollection<Combatant> AllCombatants
        {
            get => _AllCombatants;
            set => SetAndNotify(ref _AllCombatants, value);
        }
        private ObservableCollection<Combatant> _CombatantsByInitiative;
        public ObservableCollection<Combatant> CombatantsByInitiative
        {
            get => _CombatantsByInitiative;
            set => SetAndNotify(ref _CombatantsByInitiative, value);
        }
        private ObservableCollection<Combatant> _CombatantsByName;
        public ObservableCollection<Combatant> CombatantsByName
        {
            get => _CombatantsByName;
            set => SetAndNotify(ref _CombatantsByName, value);
        }
        private ObservableCollection<Combatant> _NpcCombatants;
        public ObservableCollection<Combatant> NpcCombatants
        {
            get => _NpcCombatants;
            set => SetAndNotify(ref _NpcCombatants, value);
        }
        private ObservableCollection<Combatant> _PlayerCombatants;
        public ObservableCollection<Combatant> PlayerCombatants
        {
            get => _PlayerCombatants;
            set => SetAndNotify(ref _PlayerCombatants, value);
        }
        private ObservableCollection<Combatant> _DeadCombatants;
        public ObservableCollection<Combatant> DeadCombatants
        {
            get => _DeadCombatants;
            set => SetAndNotify(ref _DeadCombatants, value);
        }
        private string _StartDate;
        public string StartDate
        {
            get => _StartDate;
            set => SetAndNotify(ref _StartDate, value);
        }
        private string _FormattedStartDate;
        public string FormattedStartDate
        {
            get => _FormattedStartDate;
            set => SetAndNotify(ref _FormattedStartDate, value);
        }
        private bool _ShowStartTimeControls;
        public bool ShowStartTimeControls
        {
            get => _ShowStartTimeControls;
            set => SetAndNotify(ref _ShowStartTimeControls, value);
        }
        private string _CurrentDate;
        public string CurrentDate
        {
            get => _CurrentDate;
            set => SetAndNotify(ref _CurrentDate, value);
        }
        private string _FormattedCurrentDate;
        public string FormattedCurrentDate
        {
            get => _FormattedCurrentDate;
            set => SetAndNotify(ref _FormattedCurrentDate, value);
        }
        private string _LongFormatCurrentDate;
        public string LongFormatCurrentDate
        {
            get => _LongFormatCurrentDate;
            set => SetAndNotify(ref _LongFormatCurrentDate, value);
        }
        private bool _ShowCurrentTimeControls;
        public bool ShowCurrentTimeControls
        {
            get => _ShowCurrentTimeControls;
            set => SetAndNotify(ref _ShowCurrentTimeControls, value);
        }
        private int _CampaignDayCount;
        public int CampaignDayCount
        {
            get => _CampaignDayCount;
            set => SetAndNotify(ref _CampaignDayCount, value);
        }
        private bool _ShowClearKillControls;
        public bool ShowClearKillControls
        {
            get => _ShowClearKillControls;
            set => SetAndNotify(ref _ShowClearKillControls, value);
        }
        private ObservableCollection<GameMessage> _EventHistory;
        public ObservableCollection<GameMessage> EventHistory
        {
            get => _EventHistory;
            set => SetAndNotify(ref _EventHistory, value);
        }
        private string _TimeDigits;
        public string TimeDigits
        {
            get => _TimeDigits;
            set => SetAndNotify(ref _TimeDigits, value);
        }
        private string _TimeIndicator;
        public string TimeIndicator
        {
            get => _TimeIndicator;
            set => SetAndNotify(ref _TimeIndicator, value);
        }
        private int _EncounterRound;
        public int EncounterRound
        {
            get => _EncounterRound;
            set => SetAndNotify(ref _EncounterRound, value);
        }
        private ObservableCollection<Combatant> _Players;
        public ObservableCollection<Combatant> Players
        {
            get => _Players;
            set => SetAndNotify(ref _Players, value);
        }
        private Combatant _ActivePlayer;
        public Combatant ActivePlayer
        {
            get => _ActivePlayer;
            set => SetAndNotify(ref _ActivePlayer, value);
        }
        private ObservableCollection<NPC> _Npcs;
        public ObservableCollection<NPC> Npcs
        {
            get => _Npcs;
            set => SetAndNotify(ref _Npcs, value);
        }
        private NPC _ActiveNpc;
        public NPC ActiveNpc
        {
            get => _ActiveNpc;
            set => SetAndNotify(ref _ActiveNpc, value);
        }
        private ObservableCollection<NetArchitecture> _NetArchitectures;
        public ObservableCollection<NetArchitecture> NetArchitectures
        {
            get => _NetArchitectures;
            set => SetAndNotify(ref _NetArchitectures, value);
        }
        private NetArchitecture _ActiveNetArchitecture;
        public NetArchitecture ActiveNetArchitecture
        {
            get => _ActiveNetArchitecture;
            set => SetAndNotify(ref _ActiveNetArchitecture, value);
        }
        private string _ManualCurrentTime;
        public string ManualCurrentTime
        {
            get => _ManualCurrentTime;
            set => SetAndNotify(ref _ManualCurrentTime, value);
        }
        private string _ManualStartTime;
        public string ManualStartTime
        {
            get => _ManualStartTime;
            set => SetAndNotify(ref _ManualStartTime, value);
        }
        private string _QuickNotes;
        public string QuickNotes
        {
            get => _QuickNotes;
            set => SetAndNotify(ref _QuickNotes, value);
        }

        // Commands
        public ICommand DuplicateCampaign => new RelayCommand(DoDuplicateCampaign);
        private void DoDuplicateCampaign(object param)
        {
            GameCampaign duplicatedCampaign = this.DeepClone();
            duplicatedCampaign.Name += " (Copy)";
            AppData.MainModelRef.CampaignView.Campaigns.Add(duplicatedCampaign);
            AppData.MainModelRef.CampaignView.ActiveCampaign = duplicatedCampaign;
            RaiseAlert($"Campaign \"{Name}\" duplicated");
        }
        public ICommand DeleteCampaign => new RelayCommand(DoDeleteCampaign);
        private void DoDeleteCampaign(object param)
        {
            if (!HelperMethods.AskYesNoQuestion($"Delete campaign \"{Name}\"?")) { return; }
            AppData.MainModelRef.CampaignView.Campaigns.Remove(this);
            AppData.MainModelRef.CampaignView.ActiveCampaign = null;
            RaiseAlert($"Campaign \"{Name}\" deleted");
        }
        public ICommand AddCombatants => new RelayCommand(DoAddCombatants);
        private void DoAddCombatants(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(AppData.MainModelRef.CombatantView.Combatants.ToList(), AppData.MultiModeEnemies);

            if (selectionDialog.ShowDialog() == true)
            {
                int startingCount = AllCombatants.Count;
                foreach (Combatant selectedCombatant in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedCombatants)
                {
                    for (int i = 0; i < selectedCombatant.QuantityToAdd; i++)
                    {
                        Combatant newCombatant = selectedCombatant.DeepClone();
                        int existingCombatantCount = 0;
                        if (AppData.MainModelRef.SettingsView.UseArchetypeGrouping && newCombatant.Type == AppData.ComTypeStandard)
                        {
                            existingCombatantCount = AllCombatants.Where(c => c.ComClass == newCombatant.ComClass).Count();
                        }
                        else
                        {
                            existingCombatantCount = AllCombatants.Where(c => c.Name == newCombatant.Name).Count();
                        }
                        if (existingCombatantCount > 25) { break; }
                        newCombatant.SetDisplayName(HelperMethods.GetAlphabetLetter(existingCombatantCount));
                        newCombatant.InitializeLoadedCombatant();
                        AllCombatants.Add(newCombatant);
                    }
                }
                SortCombatantsToLists();
                RaiseAlert($"{AllCombatants.Count - startingCount} combatant(s) added");
            }
        }
        public ICommand AddPlayers => new RelayCommand(DoAddPlayers);
        private void DoAddPlayers(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(Players.ToList().ToNamedRecordList(), "Players");

            if (selectionDialog.ShowDialog() == true)
            {
                foreach (NamedRecord selectedRecord in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedRecords)
                {
                    Combatant playerToAdd = Players.First(c => c.Name == selectedRecord.Name).DeepClone();
                    if (AllCombatants.FirstOrDefault(p => p.Name == playerToAdd.Name) != null) { continue; }
                    playerToAdd.Type = AppData.ComTypePlayer;
                    AllCombatants.Add(playerToAdd);
                }
                SortCombatantsToLists();
            }
        }
        public ICommand AddNpcs => new RelayCommand(DoAddNpcs);
        private void DoAddNpcs(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(Npcs.Where(npc => !string.IsNullOrEmpty(npc.BaseCombatant)).ToList().ToNamedRecordList(), "NPCs");
            if (selectionDialog.ShowDialog() == true)
            {
                int startingCount = AllCombatants.Count;
                foreach (NamedRecord selectedRecord in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedRecords)
                {
                    NPC npc = Npcs.First(n => n.Name == selectedRecord.Name);
                    Combatant npcToAdd = AppData.MainModelRef.CombatantView.Combatants.First(c => c.Name == npc.BaseCombatant).DeepClone();
                    npcToAdd.DisplayName = npc.Name;
                    npcToAdd.Type = AppData.ComTypeNPC;
                    npcToAdd.IsAlly = npc.IsAlly;
                    npcToAdd.PortraitFilePath = npc.PortraitFilePath;
                    npcToAdd.InitializeLoadedCombatant();
                    AllCombatants.Add(npcToAdd);
                }
                SortCombatantsToLists();
                RaiseAlert($"{AllCombatants.Count - startingCount} NPC(s) added");
            }
        }
        //public ICommand AddBlackIce => new RelayCommand(DoAddBlackIce);
        //private void DoAddBlackIce(object param)
        //{
        //    MultiObjectSelectionDialog selectionDialog = new(AppData.BlackIcePrograms, AppData.MultiModeEnemies);

        //    if (selectionDialog.ShowDialog() == true)
        //    {
        //        int startingCount = AllCombatants.Count;
        //        foreach (Combatant selectedCombatant in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedCombatants)
        //        {
        //            for (int i = 0; i < selectedCombatant.QuantityToAdd; i++)
        //            {
        //                Combatant newCombatant = selectedCombatant.DeepClone();
        //                int existingCreatureCount = AllCombatants.Where(c => c.Name == newCombatant.Name).Count();
        //                if (existingCreatureCount > 25) { break; }
        //                newCombatant.SetDisplayName(HelperMethods.GetAlphabetLetter(existingCreatureCount));
        //                newCombatant.Initiative = 50; // Top of the order force
        //                newCombatant.UpdateWoundState();
        //                AllCombatants.Add(newCombatant);
        //            }
        //        }
        //        SortCombatantsToLists();
        //        RaiseAlert($"{AllCombatants.Count - startingCount} Black ICE(s) added");
        //    }
        //}
        //public ICommand AddDemons => new RelayCommand(DoAddDemons);
        //private void DoAddDemons(object param)
        //{
        //    MultiObjectSelectionDialog selectionDialog = new(AppData.Demons, AppData.MultiModeEnemies);

        //    if (selectionDialog.ShowDialog() == true)
        //    {
        //        foreach (Combatant selectedCombatant in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedCombatants)
        //        {
        //            for (int i = 0; i < selectedCombatant.QuantityToAdd; i++)
        //            {
        //                Combatant newCombatant = selectedCombatant.DeepClone();
        //                int existingCreatureCount = AllCombatants.Where(c => c.Name == newCombatant.Name).Count();
        //                if (existingCreatureCount > 25) { break; }
        //                newCombatant.SetDisplayName(HelperMethods.GetAlphabetLetter(existingCreatureCount));
        //                newCombatant.Initiative = 70; // Top(est) of the order force
        //                newCombatant.UpdateWoundState();
        //                AllCombatants.Add(newCombatant);
        //            }
        //        }
        //        SortCombatantsToLists();
        //    }
        //}
        //public ICommand AddActiveDefenses => new RelayCommand(DoAddActiveDefenses);
        //private void DoAddActiveDefenses(object param)
        //{
        //    MultiObjectSelectionDialog selectionDialog = new(AppData.ActiveDefenses, AppData.MultiModeEnemies);

        //    if (selectionDialog.ShowDialog() == true)
        //    {
        //        foreach (Combatant selectedCombatant in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedCombatants)
        //        {
        //            for (int i = 0; i < selectedCombatant.QuantityToAdd; i++)
        //            {
        //                Combatant newCombatant = selectedCombatant.DeepClone();
        //                int existingCreatureCount = AllCombatants.Where(c => c.Name == newCombatant.Name).Count();
        //                if (existingCreatureCount > 25) { break; }
        //                newCombatant.ReadyUpActiveDefense(existingCreatureCount);
        //                AllCombatants.Add(newCombatant);
        //            }
        //        }
        //        SortCombatantsToLists();
        //    }
        //}
        //public ICommand AddEmplacedDefenses => new RelayCommand(DoAddEmplacedDefenses);
        //private void DoAddEmplacedDefenses(object param)
        //{
        //    MultiObjectSelectionDialog selectionDialog = new(AppData.EmplacedDefenses, AppData.MultiModeEnemies);

        //    if (selectionDialog.ShowDialog() == true)
        //    {
        //        foreach (Combatant selectedCombatant in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedCombatants)
        //        {
        //            for (int i = 0; i < selectedCombatant.QuantityToAdd; i++)
        //            {
        //                Combatant newCombatant = selectedCombatant.DeepClone();
        //                int existingCreatureCount = AllCombatants.Where(c => c.Name == newCombatant.Name).Count();
        //                if (existingCreatureCount > 25) { break; }
        //                newCombatant.SetDisplayName(HelperMethods.GetAlphabetLetter(existingCreatureCount));
        //                newCombatant.Initiative = 60; // Top(er) of the order force
        //                newCombatant.ReloadAllWeapons();
        //                newCombatant.UpdateWoundState();
        //                AllCombatants.Add(newCombatant);
        //            }
        //        }
        //        SortCombatantsToLists();
        //    }
        //}
        public ICommand ChangeStartTime => new RelayCommand(DoChangeStartTime);
        private void DoChangeStartTime(object param)
        {
            try
            {
                string timescale = param.ToString()!.Split(',')[0];
                int quantity = Convert.ToInt32(param.ToString()!.Split(',')[1]);
                SetStartDateValues(AdjustDateTime(StartDate, timescale, quantity));
            }
            catch (Exception e)
            {
                RaiseError(e.Message);
            }
        }
        public ICommand ChangeCurrentTime => new RelayCommand(DoChangeCurrentTime);
        private void DoChangeCurrentTime(object param)
        {
            try
            {
                string timescale = param.ToString()!.Split(',')[0];
                int quantity = Convert.ToInt32(param.ToString()!.Split(',')[1]);
                SetCurrentDateValues(AdjustDateTime(CurrentDate, timescale, quantity));
            }
            catch (Exception e)
            {
                RaiseError(e.Message);
            }
        }
        public ICommand RollDice => new RelayCommand(DoRollDice);
        private void DoRollDice(object param)
        {
            int result = AppData.RNG.Next(1, Convert.ToInt32(param) + 1);
            string message = "DM rolls 1d" + param + "\nResult: " + result;
            HelperMethods.AddToGameplayLog(message, AppData.MessageGmRoll);
        }
        public ICommand FlipCoin => new RelayCommand(DoFlipCoin);
        private void DoFlipCoin(object param)
        {
            int result = AppData.RNG.Next(1, 3);
            HelperMethods.AddToGameplayLog(string.Format("DM flips a coin.\nResult: {0}.", (result == 1) ? "Heads" : "Tails"), AppData.MessageCoinFllip);
        }
        public ICommand ClearEventHistory => new RelayCommand(DoClearEventHistory);
        private void DoClearEventHistory(object param)
        {
            if (param == null) { HelperMethods.WriteToLogFile("No parameter passed for GameCampaign.DoClearEventHistory.", true); return; }
            switch (param.ToString())
            {
                case "All":
                    if (HelperMethods.AskYesNoQuestion("Clear message history?") == false) { return; }
                    EventHistory.Clear();
                    break;
                case "After10":
                    EventHistory = new(EventHistory.Take(10));
                    break;
                case "After50":
                    EventHistory = new(EventHistory.Take(50));
                    break;
                default:
                    HelperMethods.WriteToLogFile($"Invalid parameter {param} passed to GameCampaign.DoClearMessages.", true);
                    return;
            }

        }
        public ICommand ChangeActiveCombatant => new RelayCommand(DoChangeActiveCombatant);
        private void DoChangeActiveCombatant(object param)
        {
            if (CombatantsByInitiative.Count <= 0) { return; }
            Combatant activeCombatant = CombatantsByInitiative.FirstOrDefault(c => c.IsActive)!;
            Combatant firstCombatant = CombatantsByInitiative.FirstOrDefault(c => c.Type != AppData.ComTypeActiveDefense && c.Type != AppData.ComTypeEmplacedDefense)!;
            Combatant lastCombatant = CombatantsByInitiative.Last();
            if (activeCombatant == null) { param = "Reset"; }
            string action = param.ToString()!;
            switch (action)
            {
                case "Next":
                    bool foundNext = false;
                    int indexOfNext = -1;
                    do
                    {
                        if (indexOfNext == -1)
                        {
                            indexOfNext = (activeCombatant == lastCombatant) ? 0 : CombatantsByInitiative.IndexOf(activeCombatant!) + 1;
                        }
                        if (indexOfNext >= CombatantsByInitiative.Count) { indexOfNext = 0; }
                        if (indexOfNext == 0) { EncounterRound++; }
                        if (CombatantsByInitiative[indexOfNext] == activeCombatant) { return; } // if it makes a full round and finds nothing
                        if (!IsEligibleCombatant(CombatantsByInitiative[indexOfNext])) { indexOfNext++; }
                        else { CombatantsByInitiative[indexOfNext].IsActive = true; foundNext = true; }
                        MarkCombatantsInactiveExcept(CombatantsByInitiative[indexOfNext]);
                        UpdateActiveCombatant();
                    }
                    while (foundNext == false);
                    break;
                case "Previous":
                    bool foundPrev = false;
                    int indexOfPrevious = -1;
                    do
                    {
                        if (indexOfPrevious == -1)
                        {
                            indexOfPrevious = (activeCombatant == firstCombatant) ? CombatantsByInitiative.IndexOf(lastCombatant) : CombatantsByInitiative.IndexOf(activeCombatant!) - 1;
                        }
                        if (indexOfPrevious == (CombatantsByInitiative.IndexOf(lastCombatant))) { EncounterRound--; }
                        if (EncounterRound == 0) { EncounterRound = 1; return; }
                        if (CombatantsByInitiative[indexOfPrevious] == activeCombatant) { return; } // if it makes a full round and finds nothing
                        if (!IsEligibleCombatant(CombatantsByInitiative[indexOfPrevious])) { indexOfPrevious--; }
                        else { CombatantsByInitiative[indexOfPrevious].IsActive = true; foundPrev = true; }
                        MarkCombatantsInactiveExcept(CombatantsByInitiative[indexOfPrevious]);
                        UpdateActiveCombatant();
                    }
                    while (foundPrev == false);
                    break;
                case "Reset":
                    if (HelperMethods.AskYesNoQuestion("Reset combat to round 1?") == false) { return; }
                    Combatant resetCombatant = CombatantsByInitiative.FirstOrDefault(crt => (!crt.IsDead || crt.Type == AppData.ComTypePlayer) && crt.Type != AppData.ComTypeActiveDefense && crt.Type != AppData.ComTypeEmplacedDefense)!;
                    if (resetCombatant == null) { UpdateActiveCombatant(); return; }
                    else { resetCombatant.IsActive = true; }
                    EncounterRound = 1;
                    MarkCombatantsInactiveExcept(resetCombatant);
                    UpdateActiveCombatant();
                    break;
                default:
                    break;
            }
        }
        public ICommand RollInitatives => new RelayCommand(DoRollInitatives);
        private void DoRollInitatives(object param)
        {
            List<string> initiativeResults = new();
            foreach (Combatant combatant in AllCombatants)
            {
                if (combatant.Initiative == 0 && combatant.Type != AppData.ComTypePlayer) 
                { 
                    combatant.Initiative = combatant.GetInitiative(); 
                    initiativeResults.Add($"{combatant.DisplayName} : {combatant.Initiative}");
                }
            }
            HelperMethods.AddToGameplayLog($"Rolling Combatant initatives\n{initiativeResults.ToFormattedString()}", AppData.MessageInitiative);
            SortCombatantsToLists();
        }
        public ICommand SortCombatants => new RelayCommand(DoSortCombatants);
        private void DoSortCombatants(object param)
        {
            SortCombatantsToLists();
        }
        public ICommand AddPlayer => new RelayCommand(param => DoAddPlayer());
        private void DoAddPlayer()
        {
            Players.Add(new() { Name = "New Player", Type = AppData.ComTypePlayer, PortraitFilePath = AppData.PortraitDefault });
            ActivePlayer = Players.Last();
        }
        public ICommand SortPlayers => new RelayCommand(param => DoSortPlayers());
        private void DoSortPlayers()
        {
            Players = new ObservableCollection<Combatant>(Players.OrderBy(crt => crt.Name));
        }
        public ICommand AddNpc => new RelayCommand(param => DoAddNpc());
        private void DoAddNpc()
        {
            Npcs.Add(new() { Name = "New NPC", PortraitFilePath = AppData.PortraitDefault });
            ActiveNpc = Npcs.Last();
        }
        public ICommand SortNpcs => new RelayCommand(param => DoSortNpcs());
        private void DoSortNpcs()
        {
            Npcs = new(Npcs.OrderBy(npc => npc.Name));
        }
        public ICommand AddNetArchitecture => new RelayCommand(DoAddNetArchitecture);
        private void DoAddNetArchitecture(object param)
        {
            NetArchitectures.Add(new("New NET Architecture", AppData.NetArchitectureDifficultyBasic));
            ActiveNetArchitecture = NetArchitectures.Last();
        }
        public ICommand SortNetArchitectures => new RelayCommand(DoSortNetArchitectures);
        private void DoSortNetArchitectures(object param)
        {
            NetArchitectures = new(NetArchitectures.OrderBy(n => n.Name));
        }
        public ICommand LootTheFallen => new RelayCommand(DoLootTheFallen);
        private void DoLootTheFallen(object param)
        {
            int cash = 0;
            Dictionary<string, int> ammoLoot = new();
            Dictionary<string, int> weaponLoot = new();
            Dictionary<string, int> armorLoot = new();
            Dictionary<string, int> gearLoot = new();
            Dictionary<string, int> cyberwareLoot = new();
            foreach (Combatant combatant in AllCombatants)
            {
                if (combatant.IsDead)
                {
                    cash += AppData.RNG.Next(10, 80);
                    foreach (Ammo ammo in combatant.AmmoInventory)
                    {
                        ammoLoot.AddPlus(ammo.Type, ammo.Quantity);
                    }
                    foreach (CombatantWeapon weapon in combatant.Weapons)
                    {
                        if (combatant.Type.IsIn(AppData.ComTypeEmplacedDefense, AppData.ComTypeActiveDefense)) { continue; }
                        if (weapon.UsesAmmo)
                        {
                            string ammoType = AppData.WeaponRepository.First(w => w.Type == weapon.Type).AmmoType;
                            ammoLoot.AddPlus(ammoType, weapon.CurrentClipQuantity);
                        }
                        weaponLoot.AddPlus($"{weapon.Name} ({weapon.Quality})", 1);
                    }
                    foreach (Gear gear in combatant.GearInventory)
                    {
                        gearLoot.AddPlus(gear.Name, gear.Quantity);
                    }
                    if (combatant.CurrentHeadStoppingPower > 0)
                    {
                        armorLoot.AddPlus($"{combatant.ArmorType} Head Armor ({combatant.CurrentHeadStoppingPower}/{combatant.MaximumHeadStoppingPower})", 1);
                    }
                    if (combatant.CurrentBodyStoppingPower > 0)
                    {
                        armorLoot.AddPlus($"{combatant.ArmorType} Body Armor ({combatant.CurrentBodyStoppingPower}/{combatant.MaximumBodyStoppingPower})", 1);
                    }
                    foreach (Cyberware cyberware in combatant.InstalledCyberware)
                    {
                        cyberwareLoot.AddPlus(cyberware.Name, 1);
                    }
                }
            }
            string output =
                $"Bodies were looted:\n" +
                $"**CASH**\n{cash.RoundUp()}eb\n" +
                $"**AMMO**\n{ammoLoot.ToFormattedString()}\n" +
                $"**WEAPONS**\n{weaponLoot.ToFormattedString()}\n" +
                $"**GEAR**\n{gearLoot.ToFormattedString()}\n" +
                $"**ARMOR**\n{armorLoot.ToFormattedString()}\n" +
                $"**CYBERWARE**\n{cyberwareLoot.ToFormattedString()}\n";
            if (AreAllEmpty(ammoLoot, weaponLoot, gearLoot, armorLoot, cyberwareLoot)) { HelperMethods.AddToGameplayLog("No loot found."); }
            else { HelperMethods.AddToGameplayLog(output, AppData.MessageLoot); }
            RemoveTheFallen();
        }
        public ICommand RemoveCombatants => new RelayCommand(DoRemoveCombatants);
        private void DoRemoveCombatants(object param)
        {
            const string paramAll = "All";
            const string paramDead = "Dead";
            const string paramKill = "Kill";
            if (param == null) { return; }
            switch (param.ToString())
            {
                case paramAll:
                    if (HelperMethods.AskYesNoQuestion("Are you sure you want to removal all combatants?") == false) { return; }
                    ResetCombatantLists();
                    break;
                case paramDead:
                    RemoveTheFallen();
                    break;
                case paramKill:
                    if (!HelperMethods.AskYesNoQuestion("Are you sure you want to kill all non-player and non-NPC combatants?")) { return; }
                    foreach (Combatant combatant in AllCombatants)
                    {
                        if (combatant.Type == AppData.ComTypeNPC) { continue; }
                        combatant.CurrentHitPoints = 0;
                        combatant.IsDead = true;
                    }
                    break;
            }
            SortCombatantsToLists();
        }
        public ICommand SetStartTime => new RelayCommand(DoSetStartTime);
        private void DoSetStartTime(object param)
        {
            bool isValidDate = DateTime.TryParse(ManualStartTime, out DateTime result);
            if (!isValidDate) { RaiseError("Invalid entry for DateTime"); return; }
            SetStartDateValues(result);
        }
        public ICommand SetCurrentTime => new RelayCommand(DoSetCurrentTime);
        private void DoSetCurrentTime(object param)
        {
            bool isValidDate = DateTime.TryParse(ManualCurrentTime, out DateTime result);
            if (!isValidDate) { RaiseError("Invalid entry for DateTime"); return; }
            SetCurrentDateValues(result);
        }

        // Public Methods
        public void UpdateActiveCombatant()
        {
            ActiveCombatant = CombatantsByInitiative.FirstOrDefault(c => c.IsActive)!;
        }
        public void MarkCombatantsInactiveExcept(Combatant activeCombatant)
        {
            foreach (Combatant combatant in AllCombatants)
            {
                if (combatant != activeCombatant) { combatant.IsActive = false; }
            }
            SortCombatantsToLists();
        }

        // Private Methods
        private void RemoveTheFallen()
        {
            List<Combatant> combatants = new();
            foreach (Combatant combatant in AllCombatants)
            {
                if (combatant.Type == AppData.ComTypePlayer) { combatants.Add(combatant); continue; }
                if (combatant.Type == AppData.ComTypeBlackIce || combatant.Type == AppData.ComTypeDemon || combatant.Type == AppData.ComTypeActiveDefense || combatant.Type == AppData.ComTypeEmplacedDefense)
                {
                    if (combatant.CurrentHitPoints <= 0) { continue; }
                }
                if (combatant.IsDead) { continue; }
                combatants.Add(combatant);
            }
            AllCombatants = new(combatants);
            SortCombatantsToLists();
        }
        private static bool IsEligibleCombatant(Combatant combatant)
        {
            if (combatant.Type == AppData.ComTypeActiveDefense || combatant.Type == AppData.ComTypeEmplacedDefense) { return false; }
            if (combatant.Type.IsIn(AppData.ComTypeBlackIce, AppData.ComTypeDemon) && combatant.CurrentHitPoints == 0) { return false; }
            return !combatant.IsDead || combatant.Type == AppData.ComTypePlayer;
        }
        private void InitializeLists()
        {
            ResetCombatantLists();
            EventHistory = new();
            Players = new();
            Npcs = new();
            NetArchitectures = new();
        }
        private void SortCombatantsToLists()
        {
            if (AllCombatants.Count == 0)
            {
                ResetCombatantLists();
                return;
            }
            CombatantsByInitiative = new(AllCombatants.Where(c => !c.IsDead || c.Type == AppData.ComTypePlayer).OrderByDescending(c => c.Initiative));
            CombatantsByName = new(AllCombatants.Where(c => !c.IsDead || c.Type == AppData.ComTypePlayer).OrderBy(c => c.Type != AppData.ComTypePlayer).ThenBy(c => c.DisplayName));
            PlayerCombatants = new(AllCombatants.Where(c => c.Type == AppData.ComTypePlayer).OrderBy(c => c.Name));
            NpcCombatants = new(AllCombatants.Where(c => c.Type == AppData.ComTypeNPC).OrderBy(c => c.Name));
            DeadCombatants = new(AllCombatants.Where(c => c.IsDead));
        }
        private void ResetCombatantLists()
        {
            AllCombatants = new();
            CombatantsByInitiative = new();
            CombatantsByName = new();
            NpcCombatants = new();
            PlayerCombatants = new();
            DeadCombatants = new();
        }
        private static DateTime AdjustDateTime(string currentDateTime, string timescale, int quantity)
        {
            DateTime dateTime = Convert.ToDateTime(currentDateTime);

            if (timescale == "Minutes") { return dateTime.AddMinutes(quantity); }
            if (timescale == "Hours") { return dateTime.AddHours(quantity); }
            if (timescale == "Days") { return dateTime.AddDays(quantity); }

            return dateTime;
        }
        private void SetStartDateValues(DateTime dateTime)
        {
            StartDate = dateTime.ToString();
            FormattedStartDate = dateTime.ToString(AppData.ShortDateFormat);
            UpdateDayCount();
        }
        private void SetCurrentDateValues(DateTime dateTime)
        {
            CurrentDate = dateTime.ToString();
            FormattedCurrentDate = dateTime.ToString(AppData.ShortDateFormat);
            LongFormatCurrentDate = dateTime.ToString(AppData.LongDateFormat);
            TimeDigits = $"{Get12Hour(dateTime.Hour)}:{GetMinute(dateTime.Minute)}";
            TimeIndicator = dateTime.Hour >= 12 ? "PM" : "AM";
            UpdateDayCount();
        }
        private void UpdateDayCount()
        {
            CampaignDayCount = (Convert.ToDateTime(CurrentDate) - Convert.ToDateTime(StartDate)).Days;
        }
        private static string Get12Hour(int hours)
        {
            if (hours == 0) { return "12"; }
            if (hours <= 12) { return $"{hours}"; }
            if (hours > 12 && hours < 22) { return $"{hours - 12}"; }
            else { return (hours - 12).ToString(); }
        }
        private static string GetMinute(int minutes)
        {
            if (minutes < 10) { return $"0{minutes}"; }
            else { return $"{minutes}"; }
        }

        private static bool AreAllEmpty(params Dictionary<string,int>[] collections)
        {
            foreach (Dictionary<string,int> collection in collections)
            {
                if (collection.Count > 0) { return false; }
            }
            return true;
        }

    }
}
