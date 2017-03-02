using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Fairy_tail.Сlasses;
using Fairy_tail.Interfaces;

namespace Fairy_tail.Сlasses
{
    class Menu
    {
        private HostWriter hostWriter = new HostWriter();
        private Dictionary<string, Сharacter> heroes = new Dictionary<string, Сharacter>(6);
        private string command;

        public Menu()
        {
            CreateHeroes();
        }

        public void Run()
        {
            Console.WindowWidth = 92;
            Console.WindowHeight = 40;
            PrintMessage(hostWriter.GetStartSpeech());
            GetCommandByKeyBoard();

            ShowTwedleScene();
            GetCommandByKeyBoard();

            ShowHumptyRamptyScene();
            GetCommandByKeyBoard();

            ShowCaterpillarPizzaScene();
            GetCommandByKeyBoard();

            ShowHatterScene();
            GetCommandByKeyBoard();
        }

        private void CreateHeroes()
        {
            heroes.Add("Alice", new Alice("Алиса", 10, 100));
            heroes.Add("JavaMan", new TweedleJava("Труляля", 10, 100));
            heroes.Add("SharpMan", new TweedleSharp("Траляля", 10, 100));
            heroes.Add("HREgg", new HumptyRumpty("Шалтай Болтай", 10, 100));
            heroes.Add("CaterpillarPizza", new CaterpillarPizza("Гусеница", 10, 100));
            heroes.Add("Hatter", new Hatter("Шляпник", 10, 100));
        }

        private void PrintMessage(string message)
        {
            foreach(char item in message)
            {
                Console.Write(item);
                //Thread.Sleep(10);
            }
            Console.WriteLine();
        }

        private void GetCommandByKeyBoard()
        {
            command = Console.ReadLine().ToLower();
        }
        //Done
        private void ShowTwedleScene()
        {
            PrintMessage(hostWriter.GetOpeningWordsOfTheTweedleScene());
            GetCommandByKeyBoard();

            ITweedleSharpDiscussable sharpFun = heroes["SharpMan"] as ITweedleSharpDiscussable;
            ITweedleJavaDiscussable javaFun = heroes["JavaMan"] as ITweedleJavaDiscussable;

            PrintMessage(sharpFun.GetSharpDiscussComments());
            GetCommandByKeyBoard();

            PrintMessage(javaFun.GetJavaDiscussComments());
            GetCommandByKeyBoard();

            PrintMessage(hostWriter.GetMiddleWordsOfTheTweedleScene());
            PrintMessage("\n\tПоддержать C# разработчика, нажмите : # ");
            PrintMessage("\tПоддержать Java разработчика, нажмите : J ");

            while(!("j" == command || "#" == command))
            {
                Console.Write("\tВаш выбор : ");
                GetCommandByKeyBoard();
            }

            if ("#" == command)
            {
                hostWriter.ProgressGrowth(2);
                ITweedleSharpDiscussable aliceForSharp = heroes["Alice"] as ITweedleSharpDiscussable;
                GetCommandByKeyBoard();
                PrintMessage(aliceForSharp.GetSharpDiscussComments());
            }
            else 
            {
                hostWriter.ProgressGrowth(1);
                ITweedleJavaDiscussable aliceForJava = heroes["Alice"] as ITweedleJavaDiscussable;
                GetCommandByKeyBoard();
                PrintMessage(aliceForJava.GetJavaDiscussComments());
            }

            GetCommandByKeyBoard();
            PrintMessage(hostWriter.GetFinalgWordsOfTheTweedleScene());
        }
        //Done
        private void ShowHumptyRamptyScene()
        {
            PrintMessage(hostWriter.GetOpeningWordsOfTheHRScene());
            GetCommandByKeyBoard();

            IHRDiscussable hrEgg = heroes["HREgg"] as IHRDiscussable;

            PrintMessage(hrEgg.GetHRDiscussComments());
            GetCommandByKeyBoard();

            IHRDiscussable aliceWithHR = heroes["Alice"] as IHRDiscussable;
            PrintMessage(aliceWithHR.GetHRDiscussComments());
            GetCommandByKeyBoard();


            PrintMessage(hostWriter.GetMiddleWordsOfTheHRScene());

            PrintMessage("\n\tНастойчиво попросить фидбек, введите : yes ");
            PrintMessage("\tПроигнорировать игнориррование, введите : no ");

            while (!("yes" == command || "no" == command))
            {
                Console.Write("\tВаш выбор : ");
                GetCommandByKeyBoard();
            }

            if ("yes" == command)
            {
                hostWriter.ProgressGrowth(1);
                GetCommandByKeyBoard();
                PrintMessage(hostWriter.GetFinalgWordsOfTheHRScene(true));
            }
            else
            {
                GetCommandByKeyBoard();
                PrintMessage(hostWriter.GetFinalgWordsOfTheHRScene(false));
            }
        }
        //Done
        private void ShowCaterpillarPizzaScene()
        {
            PrintMessage(hostWriter.GetOpeningWordsOfTheCaterpillarScene());
            GetCommandByKeyBoard();

            ICaterpillarPizzaDiscussable caterpillar = heroes["CaterpillarPizza"] as ICaterpillarPizzaDiscussable;
            ICaterpillarPizzaDiscussable aliceWithCaterpillar = heroes["Alice"] as ICaterpillarPizzaDiscussable;

            PrintMessage(caterpillar.GetPizzaDiscussComments());

            PrintMessage("\n\tЛевый кусок, введите : left ");
            PrintMessage("\tПравый кусок, введите : right ");

            while (!("left" == command || "right" == command))
            {
                Console.Write("\tВаш выбор : ");
                GetCommandByKeyBoard();
            }

            if ("left" == command)
            {
                hostWriter.ProgressGrowth(2);
                GetCommandByKeyBoard();
                PrintMessage(hostWriter.GetFinalgWordsOfTheCaterpillarScene(true));
            }
            else
            {
                hostWriter.ProgressGrowth(1);
                GetCommandByKeyBoard();
                PrintMessage(hostWriter.GetFinalgWordsOfTheCaterpillarScene(false));
            }

            GetCommandByKeyBoard();
            PrintMessage(aliceWithCaterpillar.GetPizzaDiscussComments());
        }

        public void ShowHatterScene()
        {
            PrintMessage(hostWriter.GetOpeningWordsOfTheHatterScene());
            GetCommandByKeyBoard();

            IHatterDiscussable hatterMan = heroes["Hatter"] as IHatterDiscussable;
        }
    }
}
