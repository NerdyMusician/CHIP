using CyberpunkGameplayAssistant.Toolbox;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public class Comparer : BaseModel
    {
        // Constructors
        public Comparer()
        {

        }
        public Comparer(NamedRecord a, NamedRecord b)
        {
            RecordA = a;
            RecordB = b;
            RecordASelected = true;
        }

        // Properties
        private bool _RecordASelected;
        public bool RecordASelected
        {
            get => _RecordASelected;
            set => SetAndNotify(ref _RecordASelected, value);
        }
        private bool _RecordBSelected;
        public bool RecordBSelected
        {
            get => _RecordBSelected;
            set => SetAndNotify(ref _RecordBSelected, value);
        }
        private NamedRecord _RecordA;
        public NamedRecord RecordA
        {
            get => _RecordA;
            set => SetAndNotify(ref _RecordA, value);
        }
        private NamedRecord _RecordB;
        public NamedRecord RecordB
        {
            get => _RecordB;
            set => SetAndNotify(ref _RecordB, value);
        }
        private bool _DescriptionDisplayed;
        public bool DescriptionDisplayed
        {
            get => _DescriptionDisplayed;
            set => SetAndNotify(ref _DescriptionDisplayed, value);
        }

        // Commands
        public ICommand ToggleSelectedRecord => new RelayCommand(DoToggleSelectedRecord);
        private void DoToggleSelectedRecord(object param)
        {
            if (param.ToString() == "A")
            {
                RecordBSelected = !RecordASelected;
            }
            if (param.ToString() == "B")
            {
                RecordASelected = !RecordBSelected;
            }
        }

    }
}
