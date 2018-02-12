using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GranolaWizard.Models
{
    public class Character : Asset
    {
        public Race Race { get; set; }
        public SkinComplexion SkinComplexion { get; set; }
        public HairColor HairColor { get; set; }
        public JobType Job { get; set; }
        public bool IsFollower { get; set; } // Can recruit to camp
        public IList<Job> Career { get; set; }
        //public IList<Skill> Skills { get; set; }
        //public IList<CharacterPreset> Relationships { get; set; }
        public EquipmentSet Equipped { get; set; }

        public int GameId { get; set; }
        public int PerkId { get; set; }
        public int JobId { get; set; }
        public int SkillId { get; set; }
        public int StatusId { get; set; }
        public int AssetId { get; set; }
    }

    public enum Race
    {
        Human,
        Cat,
        Prickleboars
    }

    public enum SkinComplexion
    {
        Human,
        Cat
    }

    public enum HairColor
    {
        Human,
        Cat
    }

    public enum JobType
    {
        Human,
        Cat
    }
}
