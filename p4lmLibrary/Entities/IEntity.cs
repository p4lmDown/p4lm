using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Entities
{
    /// <summary>
    /// entity interface
    /// </summary>
    public interface IEntity
    {
        string Name { get; set; }
        int CurrentHealth { get; set; }
        int MaxHealth { get; set; }
        int Damage { get; set; }
        void Attack(Entity entity);
    }
}