using System;
namespace project
{
    class test
    {
        public static void Main()
        {
            Double x = Convert.ToInt32(Console.ReadLine());
            Double y = Convert.ToInt32(Console.ReadLine());
            Double z=Math.Sqrt(Math.Cos(x)*Math.Abs(y-x)+Math.Sqrt(Math.Asin(x)));
            Console.WriteLine(z);
        }
    }
}