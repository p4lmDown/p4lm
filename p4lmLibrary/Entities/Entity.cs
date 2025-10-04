using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Entities
{
    /// <summary>
    /// entity class
    /// </summary>
    public class Entity : IEntity
    {
        private string _name;

        private int _currentHealth;

        private int _maxHealth;

        /// <summary>
        /// gets and sets the name of the entity
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

        /// <summary>
        /// gets and sets the current health of the entity
        /// </summary>
        public int CurrentHealth
        {
            get
            {
                return _currentHealth;
            }
            set
            {
                _currentHealth = value;
            }
        }

        /// <summary>
        /// gets and sets the max health of the entity
        /// </summary>
        public int MaxHealth
        {
            get
            {
                return _maxHealth;
            }
            set
            {
                _maxHealth = value;
            }
        }
    }
}