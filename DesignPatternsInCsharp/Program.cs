using System;



namespace DesignPatternsInCsharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //singleton
            Singleton.Singleton singleton = new Singleton.Singleton();
            Console.WriteLine(singleton.getPI());
            Console.WriteLine(singleton.getStandardGravity());

            //strategy
            Strategy.Strategy calculator = new Strategy.Rectangle(3.0, 4.0);
            calculator.printProperties();

            calculator = new Strategy.Square(3.0);
            calculator.printProperties();

            calculator = new Strategy.Circle(3.0);
            calculator.printProperties();

            //prototype
            Prototype.FirstCarProto newLambo = new Prototype.FirstCarProto("V", 500);
            newLambo[10] = "fast";
            newLambo.addProperty("luxury");

            Prototype.CarPrototype newCar = (Prototype.FirstCarProto)newLambo.Clone();


        }
    }
}
