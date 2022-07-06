// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

namespace GB.CSharp.Seminar3
{
    class HomeWorkTask3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N и мы напишем вам таблицу кубов от 1 до N!");
            int N = Convert.ToInt32(Console.ReadLine());
            int [] Array = GetCubes(N);
            int index = 0;
            Console.Write($"Таблица кубов от 1 до {N}: ");
            while(index<N)
            {
                Console.Write(Array[index] + " | ");
                index = index + 1;
            }
        }
        public static int [] GetCubes(int n)
        {
            int [] ArrayCubes = new int [n];
            int index = 1;
            while (index <= n)
            {
                ArrayCubes[index-1] = index*index*index;
                index = index + 1;
            }
            return ArrayCubes;
        }
    }
}