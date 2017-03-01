using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairy_tail.Сlasses
{
    class HostWriter
    {
        //Переменная которая ответственна за игровые очки, для изминения буду пользовать либо СВОЙСТВО либо СОБЫТИЕ
        //private int progressPoints;

        public string GetStartSpeech()
        { return "Start speech"; }
        public string GetEndSpeech()
        { return "End speech"; }

        public string GetOpeningWordsOfTheHRScene()
        { return "HR begin"; }
        public string GetFinalgWordsOfTheHRScene()
        { return "HR final"; }

        public string GetOpeningWordsOfTheHatterScene()
        { return "Hatter begin"; }
        public string GetFinalgWordsOfTheHatterScene()
        { return "Hatter final"; }

        public string GetOpeningWordsOfTheCaterpillarScene()
        { return "Caterpillar begin"; }
        public string GetFinalgWordsOfTheCaterpillarScene()
        { return "Caterpillar end"; }

        public string GetOpeningWordsOfTheTweedleScene()
        { return "Tweedle begin"; }
        public string GetFinalgWordsOfTheTweedleScene()
        { return "Tweedle end"; }
    }
}
