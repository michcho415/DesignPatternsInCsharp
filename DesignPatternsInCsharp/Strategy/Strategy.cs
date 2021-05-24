using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsInCsharp.Strategy
{
    // base class for strategy (strategy can be implemented as a interface).
    // Strategy is a design pattern that can simplify change of algorithm
    public abstract class Strategy
    {
        public abstract double calculateArea();
        public abstract double calculateCircumference();
        public abstract void printProperties();

    }

    public class Rectangle : Strategy
    {
        protected double x, y;

        public Rectangle(double _x, double _y) => (x, y) = (_x, _y);
        public override double calculateArea()
        {
            return x*y;
        }

        public override double calculateCircumference()
        {
            return 2 * x + 2 * y;
        }

        public override void printProperties()
        {
            Console.WriteLine($"Rectangle of sides {x} and {y} has area of {this.calculateArea()} and Circumference: {this.calculateCircumference()} ");
        }
    }

    public class Square : Rectangle
    {
        public Square(double x) : base(x, x)
        { }

        public override double calculateArea()
        {
            return base.calculateArea();
        }

        public override double calculateCircumference()
        {
            return base.calculateCircumference();
        }

        public override void printProperties()
        {
            Console.WriteLine($"Square of side {x} has area of {this.calculateArea()} and Circumference: {this.calculateCircumference()} ");
        }
    }

    public class Circle: Strategy
    {
        double radius;
        public Circle(double _r) => radius = _r;
        public override double calculateArea()
        {
            return Singleton.Singleton.getInstance().getPI() * radius * radius; //used Singleton design pattern
        }

        public override double calculateCircumference()
        {
            return 2 * Singleton.Singleton.getInstance().getPI() * radius;
        }

        public override void printProperties()
        {
            Console.WriteLine($"Circle of radius {radius} has area of {this.calculateArea()} and Circumference: {this.calculateCircumference()}");
        }
    }
}
