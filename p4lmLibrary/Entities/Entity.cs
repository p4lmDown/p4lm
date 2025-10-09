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

        private int _damage;

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

        /// <summary>
        /// gets and sets the damage of the entity
        /// </summary>
        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }

        /// <summary>
        /// entity attacks entity
        /// </summary>
        public void Attack(Entity entity)
        {
            int prevHealth = entity.CurrentHealth;
            entity.CurrentHealth = entity.CurrentHealth - this.Damage;

            if (entity.CurrentHealth <= 0)
            {
                Console.WriteLine($"{this.Name} delivered the final blow clocking in at {this.Damage} damage");
                return;
            }
            else
            {
                Console.WriteLine($"{this.Name} did {this.Damage} to {entity.Name}, bringing their health from {prevHealth} to {entity.CurrentHealth}");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}