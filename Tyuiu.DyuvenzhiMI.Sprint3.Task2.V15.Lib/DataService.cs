
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DyuvenzhiMI.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            do
            {
                SumSeries += (Math.Pow(value, startValue) + (1.0/2.0)) * Math.Cos(startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}
