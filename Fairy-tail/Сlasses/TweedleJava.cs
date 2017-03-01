using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fairy_tail.Interfaces;

namespace Fairy_tail.Сlasses
{
    //Java team
    class TweedleJava : Сharacter, ITweedleJavaDiscussable
    {
        public TweedleJava(string name, int hungerLevel, double hitPoints) 
            : base (name, hungerLevel, hitPoints)
        { }

        public string GetJavaDiscussComments()
        {
            return "JavaFUN comment";
        }
    }
}
