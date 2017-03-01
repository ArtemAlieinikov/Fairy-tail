using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairy_tail.Сlasses
{
    abstract class Сharacter
    {
        private string name;
        private int hungerLevel;
        private double hitPoints;

        public double HitPoints
        {
            set
            {
                if (value > 100 || value <= 0)
                {
                    hitPoints = 100;
                }
                else
                {
                    hitPoints = value;
                }
            }
        }
        public int HungerLevel
        {
            set
            {
                if (value > 10 || value <= 0)
                {
                    hungerLevel = 10;
                }
                else
                {
                    hungerLevel = value;
                }
            }
        }

        public Сharacter(string name, int hungerLevel, double hitPoint)
        {
            this.name = name;
            HungerLevel = hungerLevel;
            HitPoints = hitPoint;
        }
    }
}
