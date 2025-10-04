using p4lmLibrary.Entities;
using p4lmLibrary.Healables;
using p4lmLibrary.Items;
using p4lmLibrary.Levels;
using p4lmLibrary.PlayerInventory;
using p4lmLibrary.Weapons;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.CurrentPlayer
{
    /// <summary>
    /// player class
    /// </summary>
    public class Player : Entity
    {
        private bool _auth;

        private Role _role;

        private string _decision;

        private Level _currentLevel;

        private Weapon _currentWeapon;

        private List<Healable> _healables;

        private _Inventory _inventory;

        /// <summary>
        /// gets and sets the authorization to continue within inquiries
        /// </summary>
        public bool Auth
        {
            get
            {
                return _auth;
            }
            set
            {
                _auth = value;
            }
        }

        /// <summary>
        /// gets and sets the role of the player
        /// </summary>
        public Role Role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
            }
        }

        /// <summary>
        /// gets and sets the decision of the player
        /// </summary>
        public string Decision
        {
            get
            { 
                return _decision.ToLower();
            }
            set
            {
                _decision = value;
            }
        }

        /// <summary>
        /// gets and sets the current level of the player
        /// </summary>
        public Level CurrentLevel
        {
            get
            {
                return _currentLevel;
            }
            set
            {
                _currentLevel = value;
            }
        }

        /// <summary>
        /// gets and sets the current weapon of the player
        /// </summary>
        public Weapon CurrentWeapon
        {
            get
            {
                return _currentWeapon;
            }
            set
            {
                _currentWeapon = value;
            }
        }

        /// <summary>
        /// gets and sets the healables of the player
        /// </summary>
        public List<Healable> Healables
        {
            get
            {
                return _healables;
            }
            set
            {
                _healables = value;
            }
        }

        /// <summary>
        /// gets and sets the players inventory
        /// </summary>
        public _Inventory Inventory
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
        /// player constructor
        /// </summary>
        public Player()
        {
            CurrentHealth = 100;
            MaxHealth = 100;
            CurrentWeapon = new Fists();
            Healables = new List<Healable>();
            Healables.Add(new Bandaid());
            Inventory = new _Inventory(this);
        }
    }
}