using p4lmLibrary.CurrentPlayer;
using p4lmLibrary.CurrentPlayer.PlayerInventory;
using p4lmLibrary.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.PlayerInventory
{
    /// <summary>
    /// player inventory class
    /// </summary>
    public class _Inventory
    {
        private Slot[] _inventory;

        /// <summary>
        /// gets and sets the slots of the players inventory
        /// </summary>
        public Slot[] Inventory
        {
            get
            {
                return _inventory;
            }
            set
            {
                _inventory = value;
            }
        }
        /// <summary>
        /// inventory constructor
        /// </summary>
        public _Inventory(Player player)
        {
            Inventory = new Slot[3];
        }
    }
}
