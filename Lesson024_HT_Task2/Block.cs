using System;
namespace Lesson024_HT_Task2
{
#pragma warning disable CS0659 // Тип переопределяет Object.Equals(object o), но не переопределяет Object.GetHashCode()
    public class Block
#pragma warning restore CS0659 // Тип переопределяет Object.Equals(object o), но не переопределяет Object.GetHashCode()
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }

        public Block()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Block);
        }

        public bool Equals (Block other)
        {
            return other != null && A == other.A && B == other.B && C == other.C && D == other.D;
        }

        public override string ToString()
        {
            return $"Block: A-side - {A}, B-side - {B}, C-side - {C}, D-side - {D}";
        }

    }
}
