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
            string first = "Здравствуй Алиса, не нужно представляться, я знаю как тебя зовут и что ты есть.";
            string second = "А так же я знаю, что ты не прочь подкрепиться, я могу с тобой поделиться, но при одном условии.";
            string third = "Либо ты берешь ЛЕВЫЙ кусок пиццы и идешь пилить новую ФИЧУ, либо ты берешь ПРАВЫЙ кусок и садишся играть в XBOX360.";
            string fourth = "Не надо лишних слов, просто выбирай свой кусок.";
            return String.Format("{0}: {1} {2} {3} {4}", ToString(), first, second, third, fourth);
        }
    }
}
