using System;

namespace Euler6
{
    class Square_Sum
    {
        static void Main(string[] args)
        {
            long result = SquareSum(100) - TheSumOfSquares(100);
            Console.WriteLine($"result = {result}");
        }

        static long TheSumOfSquares(int number) // сума квадратів (number - кількість чисел доки проводити розрахунки)
        {
            long Sum = 0;

            for (int i = 1; i <= number; i++)
                Sum += i*i;
            return Sum;
        }

        static long SquareSum(int number) // квадрат суми (number - кількість чисел доки проводити розрахунки)
        {
            long Sum = 0;
            for (int i = 1; i <= number; i++) //Пошук суми
                Sum += i;
            return Sum*Sum; // Повертаємо квадрат суми
        }
    }
}
