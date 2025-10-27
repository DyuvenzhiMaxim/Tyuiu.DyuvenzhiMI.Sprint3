
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DyuvenzhiMI.Sprint3.Task3.V1.Lib
{
    public class DataService : ISprint3Task3V1
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;
            foreach (char a in value)
            {
                if (a == item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
