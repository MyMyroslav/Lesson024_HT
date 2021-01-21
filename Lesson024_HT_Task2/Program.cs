using System;

namespace Lesson024_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Block bl1 = new Block { A = 2, B = 4, C = 6, D = 1 };
            Block bl2 = new Block { A = 5, B = 2, C = 3, D = 4 };
            Block bl3 = new Block { A = 2, B = 4, C = 6, D = 1 };
            Console.WriteLine(bl1.Equals(bl2));
            Console.WriteLine(bl1.Equals(bl3));
            Console.WriteLine(bl1.ToString()); 
        }
    }
}
