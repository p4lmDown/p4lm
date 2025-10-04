using p4lmLibrary.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Weapons
{
    /// <summary>
    /// weapon class
    /// </summary>
    public class Weapon : Item, IWeapon
    {
        private int _damage;

        /// <summary>
        /// gets and sets the damage of the weapon
        /// </summary>
        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }
    }
}