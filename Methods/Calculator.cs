using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("Select Option");
            Console.WriteLine("1 : Square");
            Console.WriteLine("2 : Rectangle");
            Console.WriteLine("3 : Circle");
            Console.WriteLine("4 : Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    default:
                    case 1:
                        Console.WriteLine("Enter side length");
                        double side = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(SquareArea(side));
                        break;

                    case 2:
                        Console.WriteLine("Enter length");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter height");
                        double height = Convert.ToDouble(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Enter radius");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        break;

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static double SquareArea(double side)
        {
            return side * side;
        }

        public static double SquarePerim(double side)
        {
            return side * 4;
        }

        public static double RectArea(double lenght, double height)
        {
            return lenght * height;
        }

        public static double RectPerim(double lenght, double height)
        {
            return (lenght + height * 2);
        }

        public static double CircleArea(double radius)
        {
            return double.Pi * radius;
        }

    }
}
