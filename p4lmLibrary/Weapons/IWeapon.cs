using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Weapons
{
    /// <summary>
    /// weapon interface
    /// </summary>
    public interface IWeapon
    {
        int Damage { get; set; }
    }
}