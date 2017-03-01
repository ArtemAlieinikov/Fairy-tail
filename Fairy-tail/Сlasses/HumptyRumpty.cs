using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fairy_tail.Interfaces;

namespace Fairy_tail.Сlasses
{
    class HumptyRumpty : Сharacter, IHRDiscussable
    {
        public HumptyRumpty(string name, int hungerLevel, double hitPoints) 
            : base (name, hungerLevel, hitPoints)
        { }

        public string GetHRDiscussComments()
        {
            return "Show reaction of HREgg Шалтай HR Болтаевич";
        }
    }
}
