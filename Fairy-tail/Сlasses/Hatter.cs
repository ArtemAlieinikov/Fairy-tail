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
            string first = "Привет Алиса, ты наверное устала? Хочешь чего-то выпить? У меня есть напитки разного состава, пожалуйста, бери любую понравившуюся бутылку.";
            string second = "Определить где какой напиток, ты сможешь по надписях на этикетках.";
            return String.Format("{0}: {1} {2}", ToString(), first, second);
        }
    }
}
