// Задача 2. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите номер четверти координат и мы напишем вам диапозон значений x и y: ");
                int Q = Convert.ToInt32(Console.ReadLine());
                   
                if(Q==1)  
                {
                    Console.WriteLine("В введенной четверти I: x>0, y>0");
                }
                if(Q==2)  
                {
                    Console.WriteLine("В введенной четверти II: x<0, y>0");
                }
                if(Q==3)  
                {
                    Console.WriteLine("В введенной четверти III: x<0, y<0");
                }
                if(Q==4)  
                {
                    Console.WriteLine("В введенной четверти I: x>0, y<0");
                }
        }
    }
}

// // Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// namespace task1;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Введите номер четверти:");
//         int quarter = Convert.ToInt32(Console.ReadLine());
//         int nummax = int.MaxValue;
//         int nummin = int.MinValue;
//         int minx = 0;
//         int miny = 0;
//         int maxx = 0;
//         int maxy = 0;
//         if (quarter == 1)
//         {
//             minx = 0;
//             maxx = nummax;
//             miny = 0;
//             maxy = nummax;
//         }
//          if (quarter == 2)
//         {
//             minx = nummin;
//             maxx = 0;
//             miny = 0;
//             maxy = nummax;
//         }
//         if (quarter == 3)
//         {
//             minx = nummin;
//             maxx = 0;
//             miny = nummin;
//             maxy = 0;
//         }
//         if (quarter == 4)
//         {
//             minx = 0;
