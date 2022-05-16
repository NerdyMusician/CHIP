using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkGameplayAssistant.Models
{
    public partial class Combatant : BaseModel
    {

        // Databound Properties
        private ObservableCollection<CyberdeckProgram> _CyberdeckPrograms;
        public ObservableCollection<CyberdeckProgram> CyberdeckPrograms
        {
            get => _CyberdeckPrograms;
            set => SetAndNotify(ref _CyberdeckPrograms, value);
        }
        private ObservableCollection<CyberdeckProgram> _ActivePrograms;
        public ObservableCollection<CyberdeckProgram> ActivePrograms
        {
            get => _ActivePrograms;
            set => SetAndNotify(ref _ActivePrograms, value);
        }

    }
}
