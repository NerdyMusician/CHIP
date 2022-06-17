using CyberpunkGameplayAssistant.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class ImporterViewModel : BaseModel
    {
        // Constructors
        public ImporterViewModel(string mode, List<Comparer> comparedItems)
        {
            InitializeCollections();
            Mode = mode;
            ComparedItems = new(comparedItems);
        }
        private void InitializeCollections()
        {
            ComparedItems = new();
        }

        // Properties
        private string _Mode;
        public string Mode
        {
            get => _Mode;
            set => SetAndNotify(ref _Mode, value);
        }
        private ObservableCollection<Comparer> _ComparedItems;
        public ObservableCollection<Comparer> ComparedItems
        {
            get => _ComparedItems;
            set => SetAndNotify(ref _ComparedItems, value);
        }

    }
}
