using CyberpunkGameplayAssistant.Models;
using System;

namespace CyberpunkGameplayAssistant.Toolbox
{
    [Serializable]
    public class NamedRecord : BaseModel
    {
        // Constructors
        public NamedRecord()
        {

        }
        public NamedRecord(string name, string description)
        {
            Name = name;
            Description = description;
        }

        // Databound Properties
        #region Name
        private string _Name;
        
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        #endregion
        #region Description
        private string _Description;
        
        public string Description
        {
            get => _Description;
            set => SetAndNotify(ref _Description, value);
        }
        #endregion

    }
}
