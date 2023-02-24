using System;
using System.Numerics;

namespace AddtionDemo
{
    public class Addition
    {
        public void Add(int val1,int val2) {
            Console.WriteLine("Started Execution");
            Console.WriteLine("Inside int method");
            Console.WriteLine(val1 + val2);
        }

        public void Add(double val1,double val2)
        {
            Console.WriteLine("Inside double method");
            Console.WriteLine(val1 + val2);
        }

        public static void Main(string[] args)
        {
            Addition a1 = new Addition();
            a1.Add(5.4, 6.3);
        }
    }
}
