// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число, а мы проверим является ли оно палиндромом!");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = Convert.ToString(number);
            if(str.Length == 5)
            {
                if(str[0]==str[4] && str[1]==str[3])
                {
                    Console.WriteLine($"Число {number} является палиндромом!!!");
                }
                else
                {
                    Console.WriteLine($"Число {number} НЕ является палиндромом!!!");
                }
            }
            else
            {
                Console.WriteLine("НЕВЕРНОЕ ЗНАЧЕНИЕ");
            }
        }
    }
}