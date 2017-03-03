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
            string first = "Весьма примечательно, что джаваисты объявляют ненужным абсолютно всё ровно до того момента, пока в Джаве это таки не появляется." ;
            string second = "После этого фича внезапно становится нужной и полезной. При этом, у Джаваистов принято люто #апать на Scala, которая состоит из вышеперечисленных ништяков чуть более, чем на половину.";
            return String.Format("{0}: {1} {2}", ToString(), first, second);
        }

        public string GetJavaDiscussComments()
        {
            string first = "Молодые люди, может быть вам стоит прекратить спор и просто выпить по чашечке кофе?";
            return String.Format("{0}: {1}", ToString(), first);
        }

        public string GetHRDiscussComments()
        {
            string first = "Да, конечно, вот возьмите. Я очень рада, что вы сами меня нашли...или я вас нашла?";
            string second = "Кто же кого нашел? Ведь в начале не я вас, не вы меня не видели? Хм...В любом случае спасибо, я подожду здесь.";
            return String.Format("{0}: {1} {2}", ToString(), first, second);
        }

        public string GetPizzaDiscussComments()
        {
            string first = "Спасибо за угощения и вашу заботу, теперь я совсем не голодна и знаю чем себя занять на ближайший вечер.";
            return String.Format("{0}: {1}", ToString(), first);
        }

        public string GetHatterDiscussComments()
        {
            string first = "Спасибо, очень вкусный напиток, правда у него какой-то странный привкус....";
            return String.Format("{0}: {1}", ToString(), first);
        }
    }
}
