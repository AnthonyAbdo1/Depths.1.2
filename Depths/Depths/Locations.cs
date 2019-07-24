using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depths
{
   
    public class Locations
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TerrainType { get; set; }
        public int Rooms { get; set; }
        public int NumberOfContainers { get; set; }
    }

    //Hostile

    public class Tower:Locations
    {

    } 

    public class Dungeon:Locations
    {

    }

    public class MonsterNest:Locations
    {
        public int NumberOfMonsters { get; set; }
        public string TypeOfMonster { get; set; }
    }

    //Friendly

    public class Town
    {
        public bool HasBlacksmith { get; set; }
        public bool HasHerbalist { get; set; }
        public bool HasGeneralMerchant { get; set; }
    }

    public class Camp
    {
        public bool HasTravelingMerchant { get; set; }
    }
}
