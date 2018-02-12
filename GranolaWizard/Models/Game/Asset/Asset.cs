using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GranolaWizard.Models
{
    public abstract class Asset
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TS { get; set; }
        public string Act { get; set; }

        public AssetType AssetTypeID { get; set; }
        public Version VersionAdded { get; set; }
        public IList<Tag> Tags { get; set; }
    }

    public enum AssetType
    {
        Other,
        World,
        Character,
        Item
    }

    public enum Version
    {
        Classic,
        CoC,
        Nimin
    }

    public enum Platform
    {
        Base,
        CoC,
        Nimin,
        Holiday,
        Season,
        Approved,
        Submitted,
        Saved,
        Draft
    }
}
