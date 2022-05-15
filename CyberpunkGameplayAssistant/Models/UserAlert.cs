using System;

namespace CyberpunkGameplayAssistant.Models
{
    public class UserAlert : BaseModel
    {
        public UserAlert()
        {
            CreationDateTime = DateTime.Now;
        }
        public UserAlert(string type, string message)
        {
            Type = type;
            Message = message;
            CreationDateTime = DateTime.Now;
        }

        private string _Type;
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private string _Message;
        public string Message
        {
            get => _Message;
            set => SetAndNotify(ref _Message, value);
        }
        public DateTime CreationDateTime { get; set; }

    }
}
