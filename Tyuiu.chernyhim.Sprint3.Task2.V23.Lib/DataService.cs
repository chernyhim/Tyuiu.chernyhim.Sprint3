using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.chernyhim.Sprint3.Task2.V23.Lib
{
    public class DataService : ISprint3Task2V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            do
            {
                sum += ((Math.Pow(value, startValue) + (1.0 / 4.0)) * Math.Sin(startValue));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sum, 3);
        }
    }
}
