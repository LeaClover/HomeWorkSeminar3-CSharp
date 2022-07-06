// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

namespace GB.CSharp.Seminar3
{
    class Task3
    {
        static void Main(string[] args)
        {
              int N = Convert.ToInt32(Console.ReadLine());
              int[] squares = GetSquare(N);
              for (int i = 0; i < squares.Length; i++)
              {
                Console.WriteLine(squares [i] + " ");
              }
        }
        public static int[] GetSquare(int n)
        {
            int[] square = new int[n];
            for (int i = 1; i <= n; i++)
            {
                square[i-1] = i*i;
            }
            return square;
        }
    }
}