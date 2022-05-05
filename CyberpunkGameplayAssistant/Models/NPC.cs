using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class NPC : BaseModel
    {
        // Constructors
        public NPC()
        {

        }

        // Databound Properties
        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _BaseCombatant;
        [XmlSaveMode(XSME.Single)]
        public string BaseCombatant
        {
            get => _BaseCombatant;
            set => SetAndNotify(ref _BaseCombatant, value);
        }

        // Commands
        #region SelectBaseCreature
        public ICommand SelectBaseCreature => new RelayCommand(param => DoSelectBaseCreature());
        private void DoSelectBaseCreature()
        {
            ObjectSelectionDialog itemSelect = new(ReferenceData.Combatants.ToNamedRecordList(), "Select Base Combatant");
            if (itemSelect.ShowDialog() == true)
            {
                if (itemSelect.SelectedObject == null) { return; }
                BaseCombatant = (itemSelect.SelectedObject as NamedRecord).Name;
            }

        }
        #endregion
        #region RemoveNpcFromCampaign
        public ICommand RemoveNpcFromCampaign => new RelayCommand(param => DoRemoveNpcFromCampaign());
        private void DoRemoveNpcFromCampaign()
        {
            ReferenceData.MainModelRef.CampaignView.ActiveCampaign.Npcs.Remove(this);
        }
        #endregion


    }
}
