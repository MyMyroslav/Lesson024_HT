using System;

namespace Lesson024_HT_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            House house1 = new House(2, 5);
            House house2 = new House(4, 12);
            House deepCloneHouse = new House();
            House cloneHouse = new House();
            deepCloneHouse = house1.DeepClone();
            Console.WriteLine(deepCloneHouse.Levels + " " + deepCloneHouse.Windows);
            cloneHouse = house2.Clone();
            Console.WriteLine(cloneHouse.Levels + " " + cloneHouse.Windows);
        }
    }
}
