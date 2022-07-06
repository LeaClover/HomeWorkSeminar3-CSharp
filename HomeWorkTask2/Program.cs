// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

namespace GB.CSharp.Seminar3
{
    class HomeWorkTask2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки A: ");
            Console.WriteLine("A(x): ");
            int Ax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A(y): ");
            int Ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A(z): ");
            int Az = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B: ");
            Console.WriteLine("B(x): ");
            int Bx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B(y): ");
            int By = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B(z): ");
            int Bz = Convert.ToInt32(Console.ReadLine());
            double [] Axyz = new double [] {Ax, Ay, Az};
            double [] Bxyz = new double [] {Bx, By, Bz};
            double result = GetDisOfDots(Axyz, Bxyz);
            Console.WriteLine("Расстояние между точкой A и B = " + result);
        }
        public static double GetDisOfDots(double [] ArrayA, double [] ArrayB)
        {
            double squareX = (ArrayB[0]-ArrayA[0])*(ArrayB[0]-ArrayA[0]);
            double squareY = (ArrayB[1]-ArrayA[1])*(ArrayB[1]-ArrayA[1]);
            double squareZ = (ArrayB[2]-ArrayA[2])*(ArrayB[2]-ArrayA[2]);
            double sumXYZ = squareX + squareY + squareZ;
            double DisBetweenDots = Math.Sqrt(sumXYZ);
            return DisBetweenDots;
        }
    }
}