using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Worrior:Player
    {
        public bool HasSword {  get; private set; }
        public Worrior(string name): base(name) {
            HasSword = false;
        }
}
