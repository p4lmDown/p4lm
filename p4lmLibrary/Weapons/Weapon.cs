using p4lmLibrary.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Weapons
{
    public class Weapon : Item, IWeapon
    {
        private int _damage;

        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }
    }
}