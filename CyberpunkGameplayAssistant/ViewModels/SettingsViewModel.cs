using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class SettingsViewModel : BaseModel
    {
        // Constructors
        public SettingsViewModel()
        {

        }

        // Properties
        // Application Settings
        private bool _DebugMode;
        public bool DebugMode
        {
            get => _DebugMode;
            set => SetAndNotify(ref _DebugMode, value);
        }
        private bool _MuteAudio;
        public bool MuteAudio
        {
            get => _MuteAudio;
            set => SetAndNotify(ref _MuteAudio, value);
        }
        private bool _ExitsaveEnabled;
        public bool ExitsaveEnabled
        {
            get => _ExitsaveEnabled;
            set => SetAndNotify(ref _ExitsaveEnabled, value);
        }

        // Gameplay Settings
        private bool _UseArchetypeGrouping;
        public bool UseArchetypeGrouping
        {
            get => _UseArchetypeGrouping;
            set => SetAndNotify(ref _UseArchetypeGrouping, value);
        }
        private bool _SkillsByBase;
        public bool SkillsByBase
        {
            get => _SkillsByBase;
            set => SetAndNotify(ref _SkillsByBase, value);
        }

        // Commands
        public ICommand OverwriteSkillsBy => new RelayCommand(DoOverwriteSkillsBy);
        private void DoOverwriteSkillsBy(object param)
        {
            string setTo = SkillsByBase ? "Skills by Base" : "Skills by Level";
            if (!HelperMethods.AskYesNoQuestion($"Overwrite all combatants to use {setTo}?")) { return; }
            foreach (Combatant combatant in AppData.MainModelRef.CombatantView.Combatants)
            {
                combatant.SetSkillsByBase = SkillsByBase;
            }
            RaiseAlert($"Combatants SkillsBy set to {setTo}");
        }

        // Public Methods
        public void SaveSettings()
        {
            System.Xml.Serialization.XmlSerializer serializer = new(typeof(SettingsViewModel));
            using (System.IO.StreamWriter writer = new(AppData.FilePath_Settings))
            {
                serializer.Serialize(writer, this.DeepClone());
            }
        }

    }
}
