using p4lmLibrary.Entities;
using p4lmLibrary.Levels;
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

        private string _decision;

        private Level _currentLevel;

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
    }
}
