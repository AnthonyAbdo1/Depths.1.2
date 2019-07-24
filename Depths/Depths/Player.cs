using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depths
{
    public class Player
    {
        //Basic Stats
        private int _hp;
        private int _energy;
        private int _mentalPower;
        private int _defence;
        private int _attack;
        public int Level { get; set; }

        //Advanced Stats
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Endurance { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Willpower { get; set; }
        public int Personality { get; set; }

        //Equipment Stats 

        public Weapon PlayerWeapon { get; set; }
        public Armor PlayerArmor { get; set; }

        // Inventory Stats
        public List<Items> Inventory { get; set; }
        public int Gold { get; set; }

        //Other Stats

        //Initialized Stats
        public int HP
        {
            get { _hp = Endurance * Convert.ToInt16(1.1); return _hp; }
        }

        public int Energy
        {
            get { _energy = Endurance * Agility / Convert.ToInt16(1.1); return _energy; }
        }

        public int MentalPower
        {
            get { _mentalPower = Intelligence * Willpower / Convert.ToInt16(1.1); return _mentalPower; }
        }

        public int Defence
        {
            get { _defence = Endurance * Convert.ToInt16(1.1) + PlayerArmor.ArmorStrength; return _defence; }
        }

        public int Attack
        {
            get { _attack = Strength * Convert.ToInt16(1.1) + PlayerWeapon.WeaponDamage; return _attack; }
        }
    }
}