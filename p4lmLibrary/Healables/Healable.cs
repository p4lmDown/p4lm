using p4lmLibrary.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Healables
{
    /// <summary>
    /// healable class
    /// </summary>
    public class Healable : Item, IHealable
    {
        private int _effectiveness;

        /// <summary>
        /// gets and sets the effectiveness of the healable
        /// </summary>
        public int Effectiveness
        {
            get
            {
                return _effectiveness;
            }
            set
            {
                _effectiveness = value;
            }
        }
    }
}