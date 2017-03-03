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
            string first = "Ваше резюме, пожалуйста. Да, именно вот эту вот бумагу, которую вы держите в руках. Я его рассмотрю и вы сможете получить фидбек.";
            return String.Format("{0}: {1}", ToString(), first);
        }
    }
}
