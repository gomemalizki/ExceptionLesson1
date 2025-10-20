using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Player
    {
        public string Name { get; init; }
        public int Strength {  get; protected set; }
        public int HealingPoints {  get; protected set; }
        public Player(string name) {
            this.Name = name;
            HealingPoints = 1000;
            Strength = 100;
        }
        public void attack(Player p2) {
            Console.WriteLine("Hee-Yee");
            p2.HealingPoints -= Strength;
        }
    }
}
