using p4lmLibrary.Hub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmConsole
{
    internal class Program
    {
        // Main program
        static void Main(string[] args)
        {
            Hub hub = new Hub();
            hub.Engage();
        }
    }
}
