using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lmLibrary.Enemies
{
    public class RichTechBro : Enemy
    {
        public RichTechBro()
        {
            Name = "rich tech bro";
            BaseDamage = 5;
            DamageDecorator = 5;
            CurrentHealth = 10;
            MaxHealth = 10;
        }
    }
}