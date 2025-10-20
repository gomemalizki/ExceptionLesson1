using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Wizard : Player
    {

        public int MagicLevel { get; private set; }
        public Wizard(string name, int level) : base(name)
        {
            MagicLevel = 10;
        }
        public void CastSpell(Player p2)
        {
            Console.WriteLine("shhhhh");
            p2.HealingPoints-= MagicLevel;

        }
    }
}
