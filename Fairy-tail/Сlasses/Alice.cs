using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fairy_tail.Interfaces;

namespace Fairy_tail.Сlasses
{
    class Alice : Сharacter, ITweedleSharpDiscussable, ITweedleJavaDiscussable, IHRDiscussable, ICaterpillarPizzaDiscussable, IHatterDiscussable 
    {
        public Alice(string name, int hungerLevel, double hitPoints) 
            : base (name, hungerLevel, hitPoints)
        { }

        public string GetSharpDiscussComments()
        {
            return "Answear for C sharp";
        }

        public string GetJavaDiscussComments()
        {
            return "Answear for Java";
        }

        public string GetHRDiscussComments()
        {
            return "Give answear for HREgg";
        }

        public string GetPizzaDiscussComments()
        {
            return "Give answear for CaterpillarPizza";
        }

        public string GetHatterDiscussComments()
        {
            return "Give answear for Hatter";
        }
    }
}
