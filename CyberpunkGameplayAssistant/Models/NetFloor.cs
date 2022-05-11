using System;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class NetFloor : BaseModel
    {
        // Constructors
        public NetFloor()
        {

        }
        public NetFloor(int level, string description)
        {
            Level = level;
            Description = description;
        }

        // Databound Properties
        private int _Level;
        public int Level
        {
            get => _Level;
            set => SetAndNotify(ref _Level, value);
        }
        private string _Description;
        public string Description
        {
            get => _Description;
            set => SetAndNotify(ref _Description, value);
        }
        private string _Notes;
        public string Notes
        {
            get => _Notes;
            set => SetAndNotify(ref _Notes, value);
        }

    }
}
