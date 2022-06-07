using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class SettingsViewModel : BaseModel
    {
        // Constructors
        public SettingsViewModel()
        {

        }

        // Properties
        private bool _DebugMode;
        public bool DebugMode
        {
            get => _DebugMode;
            set => SetAndNotify(ref _DebugMode, value);
        }
        private bool _UseArchetypeGrouping;
        public bool UseArchetypeGrouping
        {
            get => _UseArchetypeGrouping;
            set => SetAndNotify(ref _UseArchetypeGrouping, value);
        }

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
