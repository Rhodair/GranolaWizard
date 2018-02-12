using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GranolaWizard.Models
{
    public class CharacterTemplate : Asset
    {
        public int GameId { get; set; }
        public int PerkId { get; set; }
        public int JobId { get; set; }
        public int SkillId { get; set; }
        public int StatusId { get; set; }
        public int AssetId { get; set; }
    }
}
