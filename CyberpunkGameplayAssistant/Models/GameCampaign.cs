using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.ViewModels;
using CyberpunkGameplayAssistant.Windows;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public class GameCampaign : BaseModel
    {
        // Constructors
        public GameCampaign()
        {
            InitializeLists();
            Name = "New Campaign";
            SetStartDateValues(ReferenceData.DefaultDate);
            SetCurrentDateValues(ReferenceData.DefaultDate);
        }

        // Databound Properties
        private string _Name;
        [XmlSaveMode(XSME.Single)]
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
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Combatant> AllCombatants
        {
            get => _AllCombatants;
            set => SetAndNotify(ref _AllCombatants, value);
        }
        private ObservableCollection<Combatant> _CombatantsByInitiative;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Combatant> CombatantsByInitiative
        {
            get => _CombatantsByInitiative;
            set => SetAndNotify(ref _CombatantsByInitiative, value);
        }
        private ObservableCollection<Combatant> _CombatantsByName;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Combatant> CombatantsByName
        {
            get => _CombatantsByName;
            set => SetAndNotify(ref _CombatantsByName, value);
        }
        private ObservableCollection<Combatant> _NpcCombatants;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Combatant> NpcCombatants
        {
            get => _NpcCombatants;
            set => SetAndNotify(ref _NpcCombatants, value);
        }
        private ObservableCollection<Combatant> _PlayerCombatants;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Combatant> PlayerCombatants
        {
            get => _PlayerCombatants;
            set => SetAndNotify(ref _PlayerCombatants, value);
        }
        private string _StartDate;
        [XmlSaveMode(XSME.Single)]
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
        [XmlSaveMode(XSME.Single)]
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
        [XmlSaveMode(XSME.Enumerable)]
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
        [XmlSaveMode(XSME.Single)]
        public int EncounterRound
        {
            get => _EncounterRound;
            set => SetAndNotify(ref _EncounterRound, value);
        }

        // Commands
        public ICommand AddCombatants => new RelayCommand(DoAddCombatants);
        private void DoAddCombatants(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(ReferenceData.Combatants, ReferenceData.MultiModeEnemies);

            if (selectionDialog.ShowDialog() == true)
            {
                foreach (Combatant selectedCombatant in (selectionDialog.DataContext as MultiObjectSelectionViewModel).SelectedCombatants)
                {
                    for (int i = 0; i < selectedCombatant.QuantityToAdd; i++)
                    {
                        Combatant newCombatant = selectedCombatant.DeepClone();
                        int existingCreatureCount = AllCombatants.Where(c => c.Name == newCombatant.Name).Count();
                        if (existingCreatureCount > 25) { break; }
                        newCombatant.SetDisplayName(HelperMethods.GetAlphabetLetter(existingCreatureCount));
                        newCombatant.InitializeLoadedCombatant();
                        AllCombatants.Add(newCombatant);
                    }
                }
                SortCombatants();
            }
        }
        public ICommand ChangeStartTime => new RelayCommand(DoChangeStartTime);
        private void DoChangeStartTime(object param)
        {
            try
            {
                string timescale = param.ToString().Split(',')[0];
                int quantity = Convert.ToInt32(param.ToString().Split(',')[1]);
                SetStartDateValues(AdjustDateTime(StartDate, timescale, quantity));
            }
            catch (Exception e)
            {
                HelperMethods.NotifyUser(e.Message);
            }
        }
        public ICommand ChangeCurrentTime => new RelayCommand(DoChangeCurrentTime);
        private void DoChangeCurrentTime(object param)
        {
            try
            {
                string timescale = param.ToString().Split(',')[0];
                int quantity = Convert.ToInt32(param.ToString().Split(',')[1]);
                SetCurrentDateValues(AdjustDateTime(CurrentDate, timescale, quantity));
            }
            catch (Exception e)
            {
                HelperMethods.NotifyUser(e.Message);
            }
        }
        public ICommand RemoveCampaign => new RelayCommand(DoRemoveCampaign);
        private void DoRemoveCampaign(object param)
        {
            ReferenceData.MainModelRef.CampaignView.Campaigns.Remove(this);
        }
        public ICommand RollDice => new RelayCommand(DoRollDice);
        private void DoRollDice(object param)
        {
            int result = ReferenceData.RNG.Next(1, Convert.ToInt32(param) + 1);
            string message = "DM rolls 1d" + param + "\nResult: " + result;
            HelperMethods.AddToGameplayLog(message, "DM Roll");
        }
        public ICommand FlipCoin => new RelayCommand(DoFlipCoin);
        private void DoFlipCoin(object param)
        {
            int result = ReferenceData.RNG.Next(1, 3);
            HelperMethods.AddToGameplayLog(string.Format("DM flips a coin.\nResult: {0}.", (result == 1) ? "Heads" : "Tails"), "Coin Flip");
        }
        public ICommand ClearEventHistory => new RelayCommand(DoClearEventHistory);
        private void DoClearEventHistory(object param)
        {
            if (param == null) { HelperMethods.WriteToLogFile("No parameter passed for GameCampaign.DoClearEventHistory.", true); return; }
            switch (param.ToString())
            {
                case "All":
                    YesNoDialog question = new("Clear message history?");
                    question.ShowDialog();
                    if (question.Answer == false) { return; }
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
            Combatant activeCombatant = CombatantsByInitiative.FirstOrDefault(c => c.IsActive);
            Combatant firstCombatant = CombatantsByInitiative.First();
            Combatant lastCombatant = CombatantsByInitiative.Last();
            if (activeCombatant == null) { param = "Reset"; }
            string action = param.ToString();
            switch (action)
            {
                case "Next":
                    bool foundNext = false;
                    int indexOfNext = -1;
                    do
                    {
                        if (indexOfNext == -1)
                        {
                            indexOfNext = (activeCombatant == lastCombatant) ? 0 : CombatantsByInitiative.IndexOf(activeCombatant) + 1;
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
                            indexOfPrevious = (activeCombatant == firstCombatant) ? CombatantsByInitiative.IndexOf(lastCombatant) : CombatantsByInitiative.IndexOf(activeCombatant) - 1;
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
                    YesNoDialog question = new("Reset combat to round 1?");
                    question.ShowDialog();
                    if (question.Answer == false) { return; }
                    Combatant resetCreature = CombatantsByInitiative.FirstOrDefault(crt => !crt.IsDead || crt.IsPlayer);
                    if (resetCreature == null) { UpdateActiveCombatant(); return; }
                    else { resetCreature.IsActive = true; }
                    EncounterRound = 1;
                    UpdateActiveCombatant();
                    break;
                default:
                    break;
            }
        }

        // Public Methods
        public void UpdateActiveCombatant()
        {
            ActiveCombatant = CombatantsByInitiative.FirstOrDefault(c => c.IsActive);
        }

        // Private Methods
        private bool IsEligibleCombatant(Combatant combatant)
        {
            return !combatant.IsDead || combatant.IsPlayer;
        }
        private void MarkCombatantsInactiveExcept(Combatant activeCombatant)
        {
            foreach (Combatant combatant in AllCombatants)
            {
                if (combatant != activeCombatant) { combatant.IsActive = false; }
            }
        }
        private void InitializeLists()
        {
            AllCombatants = new();
            CombatantsByInitiative = new();
            CombatantsByName = new();
            PlayerCombatants = new();
            NpcCombatants = new();
            EventHistory = new();
        }
        private void SortCombatants()
        {
            if (AllCombatants.Count == 0)
            {
                ResetCombatantLists();
                return;
            }
            CombatantsByInitiative = new(AllCombatants.Where(c => c.CurrentHitPoints > 0 || c.IsPlayer).OrderByDescending(c => c.Initiative).ToList());
            CombatantsByName = new(AllCombatants.Where(c => c.CurrentHitPoints > 0 || c.IsPlayer).OrderBy(c => c.IsPlayer == false).ThenBy(c => c.DisplayName));
            PlayerCombatants = new(AllCombatants.Where(c => c.IsPlayer).OrderBy(c => c.Name));
            NpcCombatants = new(AllCombatants.Where(c => c.IsNpc).OrderBy(c => c.Name));
        }
        private void ResetCombatantLists()
        {
            CombatantsByInitiative = new();
            CombatantsByName = new();
            NpcCombatants = new();
            PlayerCombatants = new();
        }
        private DateTime AdjustDateTime(string currentDateTime, string timescale, int quantity)
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
            FormattedStartDate = dateTime.ToString(ReferenceData.ShortDateFormat);
            UpdateDayCount();
        }
        private void SetCurrentDateValues(DateTime dateTime)
        {
            CurrentDate = dateTime.ToString();
            FormattedCurrentDate = dateTime.ToString(ReferenceData.ShortDateFormat);
            LongFormatCurrentDate = dateTime.ToString(ReferenceData.LongDateFormat);
            TimeDigits = $"{Get12Hour(dateTime.Hour)}:{GetMinute(dateTime.Minute)}";
            TimeIndicator = dateTime.Hour >= 12 ? "PM" : "AM";
            UpdateDayCount();
        }
        private void UpdateDayCount()
        {
            CampaignDayCount = (Convert.ToDateTime(CurrentDate) - Convert.ToDateTime(StartDate)).Days;
        }
        private string Get12Hour(int hours)
        {
            if (hours == 0) { return "12"; }
            if (hours <= 12) { return $"{hours}"; }
            if (hours > 12 && hours < 22) { return $"{hours - 12}"; }
            else { return (hours - 12).ToString(); }
        }
        private string GetMinute(int minutes)
        {
            if (minutes < 10) { return $"0{minutes}"; }
            else { return $"{minutes}"; }
        }

    }
}
