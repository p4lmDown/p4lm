using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Items
{
    /// <summary>
    /// item class
    /// </summary>
    public class Item : IItem
    {
        private string _name;

        /// <summary>
        /// gets and sets the name of the item
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}