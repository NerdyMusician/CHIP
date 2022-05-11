using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkGameplayAssistant.Models
{
    public partial class Combatant : BaseModel
    {


        // Databound Properties
        private string _PlayerName;
        public string PlayerName
        {
            get => _PlayerName;
            set => SetAndNotify(ref _PlayerName, value);
        }
        private string _PlayerRole;
        public string PlayerRole
        {
            get => _PlayerRole;
            set => SetAndNotify(ref _PlayerRole, value);
        }
        private string _Notes;
        public string Notes
        {
            get => _Notes;
            set => SetAndNotify(ref _Notes, value);
        }

    }
}
