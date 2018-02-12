using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GranolaWizard.Models
{
    public class Location : Asset
    {
        // Specific locations include cities, buildings, etc.  Accessible from the "Places" button.
        // Non-specific locations are Areas are places the player can explore in hopes of discovering other areas, along with specific locations, NPCs, and key items.  However, random encounters and item pickups are going to be the most common.
        public bool Specific { get; set; }
    }

    public enum LocationRoles
    {
        Neutral,
        Camp,
        Wild,
        Town,
        Combat
    }

    public enum LocationSpecificTemplates
    {
        Camp,
        Bazaar,
        Boat,
        Farm,
        Owca,
        TelAdre
    }

    public enum LocationNonSpecificTemplates
    {
        Nothing,
        Desert,
        Forest,
        Lake,
        Plains,
        Swamp,
        Deepwoods,
        Mountain
    }
}
