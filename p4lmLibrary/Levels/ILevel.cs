using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Levels
{
    /// <summary>
    /// level interface
    /// </summary>
    public interface ILevel
    {
        int TotalEnemies { get; set; }
        int TotalSecrets { get; set; }
        bool I { get; set; }
        bool II { get; set; }
        bool III {  get; set; }
    }
}