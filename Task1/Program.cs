// Задача 1. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.


namespace HGB.CSharp.Seminar3
{
    class Task1
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите координаты X и Y и мы определим в какой четверти координат находится точка");
                Console.WriteLine("Введите координату X: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату Y: ");
                int y = Convert.ToInt32(Console.ReadLine());    
                if(x>0 && y>0)  
                {
                    Console.WriteLine("Данная точка принадлежит к I четверти!");
                }
                if(x<0 && y>0)  
                {
                    Console.WriteLine("Данная точка принадлежит к II четверти!");
                }
                if(x<0 && y<0)  
                {
                    Console.WriteLine("Данная точка принадлежит к III четверти!");
                }
                if(x>0 && y<0)  
                {
                    Console.WriteLine("Данная точка принадлежит к IV четверти!");
                }
                if(x==0 ^ y==0)
                {
                    Console.WriteLine("Не соответствует условию!");
                }
                if(x==0 && y==0)
                {
                    Console.WriteLine("Не соответствует условию!");
                }
        }
    }
}