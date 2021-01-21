using System;

namespace Lesson024_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Points v1 = new Points { X = 5, Y = 9, Z = 12};
            Points v2 = new Points { X = 3, Y = 4, Z = 6 };

            Points vr = v1 + v2;
            Console.WriteLine("Resultant Vector X: {0} & Y:{1} & Z:{2}", vr.X, vr.Y, vr.Z);
        }
}
}
