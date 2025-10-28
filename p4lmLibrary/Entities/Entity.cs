using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Entities
{
    public class Entity : IEntity
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private int _currentHealth;

        public int CurrentHealth
        {
            get => _currentHealth;
            set => _currentHealth = value;
        }

        private int _maxHealth;

        public int MaxHealth
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }

        private int _baseDamage;

        public int BaseDamage
        {
            get => _baseDamage;
            set => _baseDamage = value;
        }

        private int _damageDecorator;

        public int DamageDecorator
        {
            get => _damageDecorator;
            set => _damageDecorator = value;
        }
    }
}