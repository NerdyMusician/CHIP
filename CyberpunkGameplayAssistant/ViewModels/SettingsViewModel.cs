using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;

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

        // Public Methods
        public void SaveSettings()
        {
            System.Xml.Serialization.XmlSerializer serializer = new(typeof(SettingsViewModel));
            using (System.IO.StreamWriter writer = new(AppData.File_SettingData))
            {
                serializer.Serialize(writer, this.DeepClone());
            }
        }

    }
}
