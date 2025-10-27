
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DyuvenzhiMI.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double S = 0;
            int k;
            for (k = startValue; k <= stopValue; k++)
            {
                double V = (Math.Pow(value, (2 * k)) + 1.0 / (k + 1)) * Math.Cos(value);
                S += V;
            }
            return Math.Round(S, 3);
        }
    }
}
