// Задача 2. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

namespace GB.CSharp.Seminar3
{
    class Task2
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите номер четверти координат и мы напишем вам диапозон значений x и y: ");
                int Q = Convert.ToInt32(Console.ReadLine());
                int max = Int32.MaxValue;
                int min = Int32.MinValue;
                   
                if(Q==1)  
                {
                    Console.WriteLine("В введенной четверти I: x>0, y>0");
                    Console.WriteLine($"X(от 0 до {max}) и Y(от 0 до {max})");
                }
                if(Q==2)  
                {
                    Console.WriteLine("В введенной четверти II: x<0, y>0");
                    Console.WriteLine($"X(от {min} до 0) и Y(от 0 до {max})");
                }
                if(Q==3)  
                {
                    Console.WriteLine("В введенной четверти III: x<0, y<0");
                    Console.WriteLine($"X(от {min} до 0) и Y(от {min} до 0)");
                }
                if(Q==4)  
                {
                    Console.WriteLine("В введенной четверти I: x>0, y<0");
                    Console.WriteLine($"X(от 0 до {max}) и Y(от {min} до 0)");
                }
        }
    }
}
