﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.chernyhim.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double mult = 1;
            while(startValue < stopValue)
            {
                startValue++;
                mult = mult * (Math.Pow(1 / (Math.Pow(value, startValue)), -1));
            }
            return Math.Round(mult, 3);
        }
    }
}
