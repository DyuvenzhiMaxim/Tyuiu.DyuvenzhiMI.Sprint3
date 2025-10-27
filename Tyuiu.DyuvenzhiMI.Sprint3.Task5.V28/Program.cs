
using Tyuiu.DyuvenzhiMI.Sprint3.Task5.V28.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Дювенжи М. И. | ПИНТб-25-1";
        //Длина строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Дювенжи Максим Иванович | ПИНТб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int x = 2;
        int startValue1 = 1; int startValue2 = 1;
        int stopValue1 = 3; int stopValue2 = 12;
        double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);
        Console.ReadLine();
    }
}