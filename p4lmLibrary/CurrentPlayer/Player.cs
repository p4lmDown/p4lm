using p4lmLibrary.Enemies;
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

        private string _result;

        private Level _currentLevel;

        private Weapon _currentWeapon;

        private List<Healable> _healables;

        private Inventory _inventory;

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
        /// gets and sets the result of the decision
        /// </summary>
        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
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
        /// gets and sets the inventory of the player
        /// </summary>
        public Inventory Inventory
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
            Inventory = new Inventory(this);
            Damage = CurrentWeapon.Damage;
        }

        /// <summary>
        /// player attacks enemy
        /// </summary>
        /// <param name="player"></param>
        /// <param name="enemy"></param>
        public void InitiateFight(Enemy enemy)
        {
            this.Auth = false;

            while (!this.Auth)
            {
                if (enemy.CurrentHealth <= 0)
                {
                    Console.WriteLine($"{enemy.Name} has died");
                    Console.ReadKey();
                    Console.Clear();

                    this.Auth = true;
                    return;
                }
                else if (this.CurrentHealth <= 0)
                {
                    Console.WriteLine($"you have died {this.Name}");
                    Console.ReadKey();
                    Console.Clear();

                    Environment.Exit(0);
                }

                this.Result = String.Empty;

                Console.WriteLine("do you want to attack, heal, or look at your inventory");
                this.Decision = Console.ReadLine();
                Console.Clear();

                while (this.Result == String.Empty)
                {
                    switch (this.Decision)
                    {
                        case "attack":
                            this.Attack(enemy);
                            enemy.Attack(this);

                            break;

                        case "heal":


                            break;

                        case "inventory":


                            break;

                        default:


                            break;
                    }
                }
            }
        }
    }
}