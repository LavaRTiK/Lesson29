using System;


namespace Lesson29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            int i = 5;
            int j = 5;
            Console.WriteLine(i.Equals(j));

            object oi = (object)i;
            object oj = (object)j;
            Console.WriteLine(oi.Equals(oj));
            var p1 = new Point() { X = 5 };
            var p2 = new Point() { X = 5 };
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(i.GetHashCode());
            Console.WriteLine(j.GetHashCode());
            Console.WriteLine(new MyClass().GetHashCode());
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.GetType());
            var pp = new Point() { X = 7, Y = new Point()};
            var pp2 = pp;
            pp2.X = 77;
            pp2.Y = new Point() { X = 99};
            Console.WriteLine(pp);
            var pp3 = pp.Clone();
            pp3.X = 88;
            pp3.Y.X = 222;
            Console.WriteLine(pp3);
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);
             Console.ReadLine();
        }
    }
}
