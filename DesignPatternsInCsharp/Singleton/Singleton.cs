using System;
using System.Collections.Generic;
using System.Text;

// Singleton is a class that has only one global instance. For example, it can have constants inside. That implementation is not thread safe.
// Singleton is not recommended design pattern and has a lot of cons.
namespace DesignPatternsInCsharp.Singleton
{
    sealed public class Singleton // sealed - class can't be inherited
    {
        private static double PI = 3.1415;
        private static double g = 9.81;
        private static double G = 6.67E-11;

        private static readonly Singleton singleton = new Singleton();

        //constructors
        public Singleton() { }
        static Singleton() { }

        //methods
        public static Singleton getInstance()
        {
            return singleton;
        }

        public double getPI() { return PI; }
        public double getGravitationalConstant() { return G; }
        public double getStandardGravity() { return g; }


    }
}
