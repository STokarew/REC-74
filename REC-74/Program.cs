using System;

namespace REC_74
{
    class Program
    {
        static float MineSum(float number1, float number2)
        {
            return number1 + number2;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое из суммируемых чисел: ");
            var Num1 = float.Parse(Console.ReadLine());
            Console.Write("Введите второе из суммируемых чисел: ");
            var Num2 = float.Parse(Console.ReadLine());
            Console.Write($"Сумма введенных чисел: {MineSum(Num1, Num2)} ");
            Console.ReadKey();
        }
    }
}
