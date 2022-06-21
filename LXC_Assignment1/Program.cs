﻿// See https://aka.ms/new-console-template for more information

// The method below allows the user to enter two different integers and sum them. 
void Addition()
{
    Console.Write("Enter first int: ");

    double first = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second int: ");

    double second = Convert.ToDouble(Console.ReadLine());

    double sum = first + second;

    Console.WriteLine("The sum of the entered integers are " + sum);

    Continue();
}

// The method below allows the user to enter two different integers and subtract the first int with the second int. 
void Subtraction()
{
    Console.Write("Enter first int: ");

    double first = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second int: ");

    double second = Convert.ToDouble(Console.ReadLine());

    double sum = first - second;

    Console.WriteLine("The sum of the entered integers are " + sum);

    Continue();
}

// The method below allows the user to enter two different integers and multiply them with each other. 
void Multiplication() 
{
    Console.Write("Enter first int: ");

    double first = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second int: ");

    double second = Convert.ToDouble(Console.ReadLine());

    double sum = first * second;

    Console.WriteLine("The faction of the entered integers are " + sum);

    Continue();
}

// The method below allows the user to enter two different integers and sum them. 
void Division() 
{
    Console.Write("Enter first int: ");

    double first = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second int: ");

    double second = Convert.ToDouble(Console.ReadLine());

    if (second != 0)
    {
        double sum = first / second;
        Console.WriteLine("The faction of the entered integers are " + sum);
    }
    else
    {
        Console.WriteLine("The second int must not be 0. Try again.");
        Division();
    }
    Continue();
}

void Menu()
{


        Console.WriteLine
            ("Welcome to the calculator menu!" + "\n" +
            "Press 1 to add." + "\n" +
            "Press 2 to subtract" + "\n" +
            "Press 3 to multiply." + "\n" +
            "Press 4 to divide");

        int numPressed = Convert.ToInt32(Console.ReadLine());

    Console.Clear();
    switch (numPressed)
        {
        
            case 1:
                Addition();
                break;
            case 2:
                Subtraction();
                break;
            case 3:
                Multiplication();
                break;
            case 4:
                Division();
                break;
            default: 
            Console.WriteLine("Nope."); 
            break;
    }

}

bool Continue()
{
    Console.WriteLine("Press any key to return to the menu. Press Q to quit.");

    
        if (Console.ReadKey().Key == ConsoleKey.Q)
        {
        Console.Clear();
        return false;
        
        }

    Console.Clear();
    Menu();

    return true;
}

Menu();