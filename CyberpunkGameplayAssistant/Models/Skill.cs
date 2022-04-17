using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkGameplayAssistant.Models
{
    public class Skill : BaseModel
    {
        // Constructors
        public Skill()
        {

        }
        public Skill(string name)
        {
            Name = name;
        }

        // Databound Properties
        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private int _Value;
        [XmlSaveMode(XSME.Single)]
        public int Value
        {
            get => _Value;
            set => SetAndNotify(ref _Value, value);
        }

    }
}
