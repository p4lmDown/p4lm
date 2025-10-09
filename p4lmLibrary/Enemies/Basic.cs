using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Enemies
{
    /// <summary>
    /// basic enemy class
    /// </summary>
    public class Basic : Enemy
    {
        public Basic()
        {
            CurrentHealth = 10;
            MaxHealth = 10;
            Damage = 10;
        }
    }
}
