﻿// Задача 2. Напишите программу, которая по заданному номеру четверти, 
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