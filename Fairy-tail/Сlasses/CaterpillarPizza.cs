using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fairy_tail.Interfaces;

namespace Fairy_tail.Сlasses
{
    class CaterpillarPizza : Сharacter, ICaterpillarPizzaDiscussable
    {
        public CaterpillarPizza(string name, int hungerLevel, double hitPoints) 
            : base (name, hungerLevel, hitPoints)
        { }

        public string GetPizzaDiscussComments()
        {
            return "Give speech about two pices of pizza or pice of mashroom";
        }
    }
}
