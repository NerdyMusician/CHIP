namespace CyberpunkGameplayAssistant.Models
{
    public class GameRole : BaseModel
    {
        // Constructors
        public GameRole()
        {

        }

        public GameRole(string name, string description)
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

    }
}
