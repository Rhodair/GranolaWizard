using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GranolaWizard.Models
{
    public class EquipmentSet
    {
        public int Head { get; set; }
        public int Shoulders { get; set; }
        public int Chest { get; set; }
        public int Wrists { get; set; }
        public int Hands { get; set; }
        public int Waist { get; set; }
        public int Legs { get; set; }
        public int Feet { get; set; }
        public IList<Item> Holding { get; set; } // 2-hand, 1-hand/shield, 1-handers, etc.
        public IList<Item> Rings { get; set; }
        public IList<Item> Trinkets { get; set; }
    }
}