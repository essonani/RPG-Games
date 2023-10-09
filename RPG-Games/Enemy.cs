using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Games
{
    public class Enemy
    {
        public int health { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }
        public Enemy(string name)
        {
            health = 100;Name = name;
        }
         public void Get_Hits(int hit_value)
        {
            health=health-hit_value;
            Console.WriteLine(Name + " got hit for " + hit_value + " damage and has "+ health + " remaining.");
            if (health <= 0)
            {
                Die();

            }
             void Die()
            {
                Console.WriteLine(Name + " has died");
                IsDead=true;
            }
            
        }

    }
}
