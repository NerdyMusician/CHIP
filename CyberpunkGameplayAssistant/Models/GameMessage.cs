using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class GameMessage : BaseModel
    {
        // Constructors
        public GameMessage()
        {
        }
        public GameMessage(string type, string content)
        {
            MessageType = type;
            MessageContent = content;
        }

        // Databound Properties
        #region MessageType
        private string _MessageType;
        
        public string MessageType
        {
            get => _MessageType;
            set => SetAndNotify(ref _MessageType, value);
        }
        #endregion
        #region MessageContent
        private string _MessageContent;
        
        public string MessageContent
        {
            get => _MessageContent;
            set => SetAndNotify(ref _MessageContent, value);
        }
        #endregion

        // Commands
        #region RemoveMessage
        public ICommand RemoveMessage => new RelayCommand(DoRemoveMessage);
        private void DoRemoveMessage(object param)
        {
            if (param == null) { return; }
            if (param.ToString() == "Campaign") 
            {
                AppData.MainModelRef.CampaignView.ActiveCampaign.EventHistory.Remove(this);
            }
        }
        #endregion

    }
}
