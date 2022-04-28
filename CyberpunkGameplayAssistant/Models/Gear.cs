using CyberpunkGameplayAssistant.Toolbox;
using System;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class Gear : BaseModel
    {
        // Constructors
        public Gear()
        {

        }
        public Gear(string name)
        {
            Name = name;
        }
        public Gear(string name, string description)
        {
            Name = name;
            Description = description;
        }

        // Databound Properties
        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Description;
        public string Description
        {
            get => _Description;
            set => SetAndNotify(ref _Description, value);
        }

    }
}
