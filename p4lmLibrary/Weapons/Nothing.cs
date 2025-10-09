using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Weapons
{
    /// <summary>
    /// no item in slot
    /// </summary>
    public class Nothing : Weapon
    {
        /// <summary>
        /// nothing constructor
        /// </summary>
        public Nothing()
        {
            Name = "nothing";
            Damage = 0;
        }
    }
}
