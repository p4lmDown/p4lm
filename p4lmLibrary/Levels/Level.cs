using p4lmLibrary.CurrentPlayer;
using p4lmLibrary.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Levels
{
    /// <summary>
    /// level class
    /// </summary>
    public class Level : ILevel
    {
        private int _totalEnemies;

        private int _totalSecrets;

        private bool _I = false;

        private bool _II = false;

        private bool _III = false;

        /// <summary>
        /// gets and sets the total enemies of the level
        /// </summary>
        public int TotalEnemies
        {
            get
            {
                return _totalEnemies;
            }
            set
            {
                _totalEnemies = value;
            }
        }

        /// <summary>
        /// gets and sets the total number of secrets in the level
        /// </summary>
        public int TotalSecrets
        {
            get
            {
                return _totalSecrets;
            }
            set
            {
                _totalSecrets = value;
            }
        }

        /// <summary>
        /// gets and sets the first third of a level
        /// </summary>
        public bool I
        {
            get
            {
                return _I;
            }
            set
            {
                _I = value;
            }
        }

        /// <summary>
        /// gets and sets the second third of a level
        /// </summary>
        public bool II
        {
            get
            {
                return _II;
            }
            set
            {
                _II = value;
            }
        }

        /// <summary>
        /// gets and sets the last third of a level
        /// </summary>
        public bool III
        {
            get
            {
                return _III;
            }
            set
            {
                _III = value;
            }
        }

        /// <summary>
        /// virtual start
        /// </summary>
        public virtual void Start(Player player)
        {
            // waddup
        }

        /// <summary>
        /// loads enemies into the level
        /// </summary>
        /// <param name="enemy"></param>
        /// <param name="amount"></param>
        public void LoadEnemy(Enemy enemy, int amount)
        {

        }
    }
}