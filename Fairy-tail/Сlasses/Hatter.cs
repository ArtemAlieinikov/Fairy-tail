using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fairy_tail.Interfaces;

namespace Fairy_tail.Сlasses
{
    class Hatter : Сharacter, IHatterDiscussable
    {
        public Hatter(string name, int hungerLevel, double hitPoints) 
            : base (name, hungerLevel, hitPoints)
        { }

        public string GetHatterDiscussComments()
        {
            return "Give speech about offering coffe or a little alcogol drink";
        }
    }
}
