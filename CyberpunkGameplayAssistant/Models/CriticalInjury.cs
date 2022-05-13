using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class CriticalInjury : BaseModel
    {
        // Constructors
        public CriticalInjury()
        {

        }
        public CriticalInjury(string name, string description)
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
        public ICommand RemoveInjury => new RelayCommand(DoRemoveInjury);
        private void DoRemoveInjury(object param)
        {
            (param as Combatant)!.CriticalInjuries.Remove(this);
        }

    }
}
