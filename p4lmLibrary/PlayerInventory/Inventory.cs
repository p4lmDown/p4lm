using p4lmLibrary.CurrentPlayer;
using p4lmLibrary.Items;
using p4lmLibrary.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.PlayerInventory
{
    /// <summary>
    /// inventory class
    /// </summary>
    public class Inventory
    {
        private Item _slot1;

        private Item _slot2;

        private Item _slot3;

        private Item _slot4;

        private Item _slot5;

        /// <summary>
        /// gets and sets player's inventory slot 1
        /// </summary>
        public Item Slot1
        {
            get
            {
                return _slot1;
            }
            set
            {
                _slot1 = value;
            }
        }

        /// <summary>
        /// gets and sets player's inventory slot 2
        /// </summary>
        public Item Slot2
        {
            get
            {
                return _slot2;
            }
            set
            {
                _slot2 = value;
            }
        }

        /// <summary>
        /// gets and sets player's inventory slot 3
        /// </summary>
        public Item Slot3
        {
            get
            {
                return _slot3;
            }
            set
            {
                _slot3 = value;
            }
        }

        /// <summary>
        /// gets and sets player's inventory slot 4
        /// </summary>
        public Item Slot4
        {
            get
            {
                return _slot3;
            }
            set
            {
                _slot4 = value;
            }
        }

        /// <summary>
        /// gets and sets player's inventory slot 5
        /// </summary>
        public Item Slot5
        {
            get
            {
                return _slot5;
            }
            set
            {
                _slot5 = value;
            }
        }

        /// <summary>
        /// inventory constructor
        /// </summary>
        /// <param name="player"></param>
        public Inventory(Player player)
        {
            Slot1 = player.CurrentWeapon;
            Slot2 = new Nothing();
            Slot3 = new Nothing();
            Slot4 = new Nothing();
            Slot5 = new Nothing();
        }

        /// <summary>
        /// add item to inventory
        /// </summary>
        public void Add(Item item)
        {
            if (Slot1.GetType() == typeof(Nothing))
            {
                Slot1 = item;
            }
            else if (Slot2.GetType() == typeof(Nothing))
            {
                Slot2 = item;
            }
            else if (Slot3.GetType() == typeof(Nothing))
            {
                Slot3 = item;
            }
            else if (Slot4.GetType() == typeof(Nothing))
            {
                Slot4 = item;
            }
            else if (Slot5.GetType() == typeof(Nothing))
            {
                Slot5 = item;
            }
            else
            {
                Console.WriteLine($"your inventory is full");
            }
        }

        /// <summary>
        /// inventory tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Slot 1: {Slot1.Name}  Slot 2: {Slot2.Name}  Slot 3: {Slot3.Name}  Slot 4: {Slot4.Name}  Slot 5: {Slot5.Name}";
        }
    }
}