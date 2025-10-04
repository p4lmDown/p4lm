using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Healables
{
    /// <summary>
    /// healable interface
    /// </summary>
    public interface IHealable
    {
        string Name { get; set; }
        int Effectiveness { get; set; }
    }
}