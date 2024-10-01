using Methods;

Calculator();


void Calculator()
{
    Console.Clear();
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
            case 1:
                Console.WriteLine("Enter side length");
                double side = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of sqaure: " + SquareArea((double)side));
                Console.ReadKey();
                Calculator();
                break;

            case 2:
                Console.WriteLine("Enter length");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter height");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of rectangle: " + RectArea(length, height));
                Console.WriteLine("Perimeter of rectangle: " + RectPerim(length, height));
                Console.ReadKey();
                Calculator();
                break;

            case 3:
                Console.WriteLine("Enter radius");
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of circle: " + CircleArea(radius));
                Console.ReadKey();
                Calculator();
                break;

            case 4:
                Environment.Exit(0);
                break;

            default:
                Console.Clear();
                Console.WriteLine("Invalid input, try again.");
                Calculator(); 
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
static double SquareArea(double side)
{
    return side * side;
}

static double SquarePerim(double side)
{
    return side * 4;
}

static double RectArea(double lenght, double height)
{
    return lenght * height;
}

static double RectPerim(double lenght, double height)
{
    return (lenght + height * 2);
}

static double CircleArea(double radius)
{
    return double.Pi * radius;
}

