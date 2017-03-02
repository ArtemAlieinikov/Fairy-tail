using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fairy_tail.Interfaces;

namespace Fairy_tail.Сlasses
{
    //Sharp team
    class TweedleSharp : Сharacter, ITweedleSharpDiscussable
    {
        public TweedleSharp(string name, int hungerLevel, double hitPoints) 
            : base (name, hungerLevel, hitPoints)
        { }

        public string GetSharpDiscussComments()
        {
            return String.Format("{0}: {1}", ToString(), "А у нас в квартире газ, LINQ, TPL, свойства, лямбды, замыкания и ещё куча ништяков, а у вас?");
        }
    }
}
