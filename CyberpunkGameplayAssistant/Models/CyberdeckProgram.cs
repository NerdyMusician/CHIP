using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class CyberdeckProgram : BaseModel
    {
        // Constructors
        public CyberdeckProgram()
        {

        }
        public CyberdeckProgram(string name, string portrait, string cClass, int atk, int def, int rez, string effect)
        {
            Name = name;
            PortraitFilePath = portrait;
            Class = cClass;
            Attack = atk;
            Defense = def;
            Rez = rez;
            Effect = effect;
        }

        // Databound Properties
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _PortraitFilePath;
        public string PortraitFilePath
        {
            get => _PortraitFilePath;
            set => SetAndNotify(ref _PortraitFilePath, value);
        }
        private string _Class;
        public string Class
        {
            get => _Class;
            set => SetAndNotify(ref _Class, value);
        }
        private int _Attack;
        public int Attack
        {
            get => _Attack;
            set => SetAndNotify(ref _Attack, value);
        }
        private int _Defense;
        public int Defense
        {
            get => _Defense;
            set => SetAndNotify(ref _Defense, value);
        }
        private int _Rez;
        public int Rez
        {
            get => _Rez;
            set => SetAndNotify(ref _Rez, value);
        }
        private string _Effect;
        public string Effect
        {
            get => _Effect;
            set => SetAndNotify(ref _Effect, value);
        }

        // Commands
        public ICommand RemoveActiveProgram => new RelayCommand(DoRemoveActiveProgram);
        private void DoRemoveActiveProgram(object param)
        {
            (param as Combatant).ActivePrograms.Remove(this);
        }

    }
}
