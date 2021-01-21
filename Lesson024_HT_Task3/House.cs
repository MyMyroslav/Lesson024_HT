using System;
namespace Lesson024_HT_Task3
{
    public class House : ICloneable<House>
    {
        public int Levels { get; set; }
        public int Windows { get; set; }

        public House()
        {

        }

        public House(int Levels, int Windows)
        {
            this.Levels = Levels;
            this.Windows = Windows;
        }

        public House Clone() { return this; }
        public House DeepClone() { return new House(Levels, Windows); }
    }

    public interface ICloneable<T>
    {
        T Clone();
        T DeepClone();
    }

}
