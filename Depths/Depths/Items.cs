using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depths
{
    public class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }    
    }

    public class Weapon:Items
    {
        public string WeaponType { get; set; }
        public int WeaponDamage { get; set; }
        public int WeaponSpeed { get; set; }        
    }

    public class Armor:Items
    {
        public string ArmorType { get; set; }
        public int ArmorStrength { get; set; }
    }

    public class Potion : Items
    {
        public string PotionEffect { get; set; }
        private TimeSpan _potionDuration;

        public TimeSpan PotionDuration
        {
            get { _potionDuration = TimeSpan.FromSeconds(30); return _potionDuration; }
        }
    }

    public class Book:Items
    {
        public string Contents { get; set; }
    }

    public class Ingredient:Items
    {
        
    }

    public class MiscItems:Items
    {

    }
}
