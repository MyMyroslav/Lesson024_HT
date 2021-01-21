using System;
namespace Lesson024_HT
{
    public struct Points
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static Points operator +(Points a, Points b)
        {
            Points v = new Points();
            v.X = a.X + b.X;
            v.Y = a.Y + b.Y;
            v.Z = a.Z + b.Z;
            return v;
        }

    }
}
