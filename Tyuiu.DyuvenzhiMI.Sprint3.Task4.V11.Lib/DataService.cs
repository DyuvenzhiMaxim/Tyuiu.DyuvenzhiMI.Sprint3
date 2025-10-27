
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DyuvenzhiMI.Sprint3.Task4.V11.Lib
{
    public class DataService : ISprint3Task4V11
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            double x;
            for (x = startValue; startValue < stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                
                res *= x / (Math.Sin(x) - x) + 2;
                startValue++;
            }
            return Math.Round(res, 2);
        }
    }
}
