// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Subtraction();


// The method below allows the user to enter two different integers and sum them. 
void Addition()
{
    Console.Write("Enter first int: ");

    int first = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second int: ");

    int second = Convert.ToInt32(Console.ReadLine());

    int sum = first + second;

    Console.Write("The sum of the entered integers are " + sum);
}

// The method below allows the user to enter two different integers and subtract the first int with the second int. 
void Subtraction()
{
    Console.Write("Enter first int: ");

    int first = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second int: ");

    int second = Convert.ToInt32(Console.ReadLine());

    int sum = first - second;

    Console.Write("The sum of the entered integers are " + sum);
}

// The method below allows the user to enter two different integers and multiply them with each other. 
void Multiplication() 
{
    Console.Write("Enter first int: ");

    int first = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second int: ");

    int second = Convert.ToInt32(Console.ReadLine());

    int sum = first * second;

    Console.Write("The faction of the entered integers are " + sum);
}

// The method below allows the user to enter two different integers and sum them. 
void Division() 
{
    Console.Write("Enter first int: ");

    int first = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second int: ");

    int second = Convert.ToInt32(Console.ReadLine());

    if(second != 0)
    {
        int sum = first / second;
        Console.Write("The faction of the entered integers are " + sum);
    }
    else
    {
        Console.WriteLine("The second int must not be 0. Try again.");
    }
   
    


}