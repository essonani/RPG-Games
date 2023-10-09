using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_Games
{



    public class Player
    {
        public Player() { }
        public int health
        {
            get; set;
        }
        public string Name { get; set; }
       public  bool IsDead { get; set; }
        public bool IsBlocking { get; set; }
        public Player(string player )
        {
            health = 100;Name=player;
        }

        public Player(int health)

        {
            this.health = 100;
        }

        public void Get_Hits(int hit_value)
        {
            if (IsBlocking)
            {
                Console.WriteLine(Name + "have successifully block the ennemy atack");
            }
            else
            {
                health = health - hit_value;
                Console.WriteLine(Name + " got hit for " + hit_value + " damage and has " + health + " remaining.");
            }
            
            
            if (health <= 0)
            {
                Die();

            }
            void Die()
            {
                Console.WriteLine(Name + " has died");
                IsDead = true;
            }
        }
        public void Heal(int amount_To_Heal)
        {
            health= health + amount_To_Heal;
            Console.WriteLine("you healed " + amount_To_Heal + "and your total health is now "+ health);
        }

}   }
