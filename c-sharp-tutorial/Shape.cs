using System;

namespace csharptutorial
{
    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }

    public interface ShapeItem {
        double area();
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double num1, double num2) {
            length = num1;
            width = num2;
        }

        public override double area()
        {
            return length * width;
        }

        // Operator loading
        public static Rectangle operator+ (Rectangle rect1, Rectangle rect2) {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectWidth);
        }
    }

    class Triangle : Shape
    {
        private double theBase;
        private double height;

        public Triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        public override double area()
        {
            return .5 * (theBase * height);
        }
    }
}
