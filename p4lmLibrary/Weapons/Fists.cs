using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Weapons
{
    /// <summary>
    /// fists (default weapon)
    /// </summary>
    public class Fists : Weapon
    {
        /// <summary>
        /// fists constructor
        /// </summary>
        public Fists()
        {
            Name = "fists";
            Damage = 5;
        }
    }
}