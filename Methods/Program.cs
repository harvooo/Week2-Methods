/*
 * COM326 - Week 2
 * Harvey Vance
 * 01/10/2024
 * Version 1
 */

Main();
void Main()
{
    int option;
    do
    {
        PrintMethod();
        option = InputOption();
        string message = GetMessage(option);
        Console.WriteLine($"You selected option {option}.");
    } while (option != 0);
}

static void PrintMethod()
{
    Console.WriteLine("Please enter a valid option from below");
    Console.WriteLine("1 : Hello in French");
    Console.WriteLine("2 : Hello in Spanish");
    Console.WriteLine("3 : Hello in German");
    Console.WriteLine("4 : Hello in Italian");
    Console.WriteLine("0 : Exit application");
}

static int InputOption()
{
    Console.Write("Enter your choice:");
    string userInput = Console.ReadLine();
    int option;

    while (!int.TryParse(userInput, out option) || option < 0 || option > 4)
    {
        Console.Write("Invalid input.");
        userInput = Console.ReadLine();
    }

    return option;
}

static string GetMessage(int option)
{
    switch (option)
    {
        case 1:
            return "Bonjour!";
        case 2:
            return "¡Hola!";
        case 3:
            return "Hallo!";
        case 4:
            return "Ciao!";
        default:
            return "Invalid option.";

    }
}