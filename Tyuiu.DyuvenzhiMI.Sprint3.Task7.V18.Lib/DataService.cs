
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DyuvenzhiMI.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[11];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {

                if (x == 0) 
                {
                    res[i] = (2.0);
                    i++;
                    continue;
                }
                double f = Math.Round(((2*x - 3) / (Math.Cos(x) + x)) + 5, 2);
                res[i] = (f);
                i++;
            }
            return res;
        }
    }
}
