using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Healables
{
    /// <summary>
    /// bandaid class
    /// </summary>
    public class Bandaid : Healable
    {
        /// <summary>
        /// bandaid constructor
        /// </summary>
        public Bandaid()
        {
            Name = "bandaid";
            Effectiveness = 10;
        }
    }
}
