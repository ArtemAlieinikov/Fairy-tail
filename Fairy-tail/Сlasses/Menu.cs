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

            PrintMessage(hostWriter.GetEndSpeech());
            PrintMessage(hostWriter.GetResults(heroes["Alice"]));

            GetCommandByKeyBoard();
        }

        private void CreateHeroes()
        {
            heroes.Add("Alice", new Alice("Алиса", 5, 50));
            heroes.Add("JavaMan", new TweedleJava("Труляля", 10, 100));
            heroes.Add("SharpMan", new TweedleSharp("Траляля", 10, 100));
            heroes.Add("HREgg", new HumptyRumpty("Шалтай Болтай", 10, 100));
            heroes.Add("CaterpillarPizza", new CaterpillarPizza("Гусеница", 10, 100));
            heroes.Add("Hatter", new Hatter("Шляпник", 10, 100));
        }

        private void PrintMessage(string message)
        {
            //В данном месте я сделал ДВА потока, что бы можно было вывести весь текст без задержек
            //Отмените комментарии что бы попробывать этот вариант.

            //Thread getChar = new Thread(new ThreadStart(GetCommandByKeyBoard));
            //getChar.Start();
            //int i = 0;
            foreach(char item in message)
            {
                Console.Write(item);
                Thread.Sleep(1); // Регурируем скорость подачи текста.
                //++i;
                //if (command != null)
                //{
                //    command = null;
                //    break;
                //}
            }
            //for (; i < message.Length; i++)
            //{
            //    Console.Write(message[i]);
            //}
            Console.WriteLine();
        }

        private void GetCommandByKeyBoard()
        {
            command = null;
            command = Console.ReadLine().ToLower();
        }

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
                heroes["Alice"].HitPoints -= 25;
                GetCommandByKeyBoard();
            }

            if ("#" == command)
            {
                hostWriter.ProgressGrowth(2);
                heroes["Alice"].HitPoints += 25;

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
                heroes["Alice"].HungerLevel -= 2;
                hostWriter.ProgressGrowth(1);
                GetCommandByKeyBoard();
                PrintMessage(hostWriter.GetFinalgWordsOfTheHRScene(true));
            }
            else
            {
                heroes["Alice"].HungerLevel += 2;
                GetCommandByKeyBoard();
                PrintMessage(hostWriter.GetFinalgWordsOfTheHRScene(false));
            }
        }

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
                heroes["Alice"].HitPoints += 25;

                GetCommandByKeyBoard();
                PrintMessage(hostWriter.GetFinalgWordsOfTheCaterpillarScene(true));
            }
            else
            {
                hostWriter.ProgressGrowth(1);
                heroes["Alice"].HitPoints -= 25;

                GetCommandByKeyBoard();
                PrintMessage(hostWriter.GetFinalgWordsOfTheCaterpillarScene(false));
            }

            GetCommandByKeyBoard();
            PrintMessage(aliceWithCaterpillar.GetPizzaDiscussComments());
        }

        private void ShowHatterScene()
        {
            PrintMessage(hostWriter.GetOpeningWordsOfTheHatterScene());
            GetCommandByKeyBoard();

            IHatterDiscussable hatterMan = heroes["Hatter"] as IHatterDiscussable;
            IHatterDiscussable aliceWithHatter = heroes["Alice"] as IHatterDiscussable;

            PrintMessage(hatterMan.GetHatterDiscussComments());

            PrintMessage("\n\tБутылочка с надписью n^2, введите : N2 ");
            PrintMessage("\tБутылочка с надписью n*log(n), введите : NlogN ");
            PrintMessage("\tБутылочка с надписью n, введите : N ");
            PrintMessage("\tБутылочка с надписью log(n), введите : logN ");
            PrintMessage("\tБутылочка с надписью const, введите : const ");

            while (!("n2" == command || "nlogn" == command || "n" == command || "logn" == command || "const" == command))
            {
                Console.Write("\tВаш выбор : ");
                GetCommandByKeyBoard();
            }

            if ("n2" == command)
            {
                hostWriter.ProgressGrowth(0);
            }
            else if ("nlogn" == command)
            {
                hostWriter.ProgressGrowth(1);
            }
            else if ("n" == command)
            {
                hostWriter.ProgressGrowth(2);
            }
            else if ("logn" == command)
            {
                hostWriter.ProgressGrowth(3);
            }
            else if ("const" == command)
            {
                heroes["Alice"].HungerLevel += 3;
                hostWriter.ProgressGrowth(5);
            }

            GetCommandByKeyBoard();
            PrintMessage(aliceWithHatter.GetHatterDiscussComments());

            GetCommandByKeyBoard();
            PrintMessage(hostWriter.GetFinalgWordsOfTheHatterScene());
    }
        
}
}