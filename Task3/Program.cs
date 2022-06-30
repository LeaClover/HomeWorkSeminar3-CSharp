// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Задача 1. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
              int a = Convert.ToInt32(Console.readLine());
              int[] squares = GetSquare(a);
              for (int i = 0; i < squares.Length; i++)
              {
                Console.WriteLine( squares [i] + " ");
              }
        }
        public static int GetSquare(int n);
        int[] square = new int[n];
        {
            for (int i = 1; i <= n; i++)
            {
                square[i - 1] = i * i;
            }
            return square;
        }
    }
}