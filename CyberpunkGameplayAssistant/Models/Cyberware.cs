using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class Cyberware : BaseModel
    {
        // Constructors
        public Cyberware()
        {

        }
        public Cyberware(string name)
        {
            Name = name;
        }
        public Cyberware(string name, string description)
        {
            Name = name;
            Description = description;
        }

        // Databound Properties
        private string _Name;
        
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

        // Commands
        public ICommand RemoveCyberware => new RelayCommand(DoRemoveCyberware);
        private void DoRemoveCyberware(object param)
        {
            (param as ObservableCollection<Cyberware>)!.Remove(this);
        }

    }
}
