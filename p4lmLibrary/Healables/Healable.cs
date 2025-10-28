using p4lmLibrary.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Healables
{
    public class Healable : Item, IHealable
    {
        private int _efficiency;

        public int Efficiency
        {
            get => _efficiency;
            set => _efficiency = value;
        }
    }
}