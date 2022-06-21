// See https://aka.ms/new-console-template for more information



// Use the menu method.
    Menu();


// The method below allows the user to enter two different integers and receive the sum of them. 
void Addition()
{
    Console.Write("Enter first int: ");

    double first = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second int: ");

    double second = Convert.ToDouble(Console.ReadLine());

    double sum = first + second;

    Console.WriteLine(first + " + " + second + " = " + sum);
    Continue();
}

// The method below allows the user to recieve the difference of two inputted integers.
void Subtraction()
{
    Console.Write("Enter first int: ");

    double first = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second int: ");

    double second = Convert.ToDouble(Console.ReadLine());

    double difference = first - second;

    Console.WriteLine(first + " - " + second + " = " + difference);

    Continue();
}

// The method below allows the user receive the product of two inputted integers. 
void Multiplication() 
{
    Console.Write("Enter first int: ");

    double first = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second int: ");

    double second = Convert.ToDouble(Console.ReadLine());

    double product = first * second;

    Console.WriteLine(first + " * " + second + " = " + product);

    Continue();
}

// The method below allows the user to receive the fraction of the numerator and the denomirator. 
void Division() 
{
    Console.Write("Enter numerator: ");

    double first = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter denomirator: ");

    double second = Convert.ToDouble(Console.ReadLine());

    if (second != 0)
    {
        double fraction = first / second;
        Console.WriteLine(first + " / " + second + " = " + fraction);
    }
    else
    {
        Console.WriteLine("The second int must not be 0. Try again.");
        Division();
    }

    Continue();
}

// The menu. 
void Menu()
{

    // General info 
        Console.WriteLine
            ("Welcome to the calculator menu!" + "\n" +
            "Press 1 to calculate the sum of two integers." + "\n" +
            "Press 2 to calculate the difference of two integers." + "\n" +
            "Press 3 to calculate the product of two integers." + "\n" +
            "Press 4 to calculate the fraction of the numerator and the denomirator." + "\n" +
            "Press 5 to quit." + "\n" +
            "When pressing one of the keys above, press ENTER to move on to the desired action.");

    
    int numPressed = Convert.ToInt32(Console.ReadLine());

    // Clear the console window when pressing on a button.

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
            case 5:
                Environment.Exit(0);
                break;
            default: 
            Console.WriteLine("The number entered does not contain anything"); 
            break;
    }

  

}

// Decide whether the user wants to return to the menu or quit.
bool Continue()
{
    Console.WriteLine("Press any key to return to the menu. Press Q to quit.");

    
        if (Console.ReadKey().Key == ConsoleKey.Q)
        {
       
        return false;
        
        }

    Console.Clear();
    Menu();

    return true;
}

