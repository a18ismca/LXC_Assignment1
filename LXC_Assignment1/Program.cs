// See https://aka.ms/new-console-template for more information

// Declaration of first and second variables so they can be assigned throughout the program. 

namespace LXC_Assignment1
{
    public class Program
    {

        static List<int> array = new List<int>();

        Program()
        {
            
        }

        public static void Main(string[] args)
        {
            Menu();
        }

        static double first, second;

        // Use the menu method.
        


        // The method below allows the user to enter two different integers and receive the sum of them. 
        static void Addition()
        {
            AskForInput(out first, out second);

            double sum = first + second;

            Console.WriteLine(first + " + " + second + " = " + sum);
            Continue();
        }

        // The method below allows the user to recieve the difference of two inputted integers.
        static void Subtraction()
        {
            AskForInput(out first, out second);

            double difference = first - second;

            Console.WriteLine(first + " - " + second + " = " + difference);

            Continue();
        }

        // The method below allows the user receive the product of two inputted integers. 
        static void Multiplication()
        {
            AskForInput(out first, out second);

            double product = first * second;

            Console.WriteLine(first + " * " + second + " = " + product);

            Continue();
        }

        // The method below allows the user to receive the fraction of the numerator and the denomirator. 
        static void Division()
        {
            AskForInput(out first, out second);

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
        static void Menu()
        {

            // General info 
            Console.WriteLine
                ("Welcome to the calculator menu!" + "\n" +
                "Press 1 to calculate the sum of two integers." + "\n" +
                "Press 2 to calculate the difference of two integers." + "\n" +
                "Press 3 to calculate the product of two integers." + "\n" +
                "Press 4 to calculate the fraction of the numerator and the denomirator." + "\n" +
                "Press 5 to calculate the sum of an array of inputted integers." + "\n" +
                "Press 6 to calculate the difference of an array of inputted integers." + "\n" +
                "Press 7 to quit." + "\n" +
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
                    Addition(array);
                    break;
                case 6:
                    Subtraction(array);
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("The number entered does not contain anything");
                    break;
            }



        }

        // Decide whether the user wants to return to the menu or quit.
        static bool Continue()
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

        // Handles inputs from the user. 
        static void AskForInput(out double first, out double second)
        {
            Console.Write("Enter first int: ");

            first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second int: ");

            second = Convert.ToDouble(Console.ReadLine());
        }


        // The overloaded method below allows the user to enter a number different integers and receive the sum of them. 
        static void Addition(List<int> arr)
        {
            Console.WriteLine("--- Array addition ---");
            AskForSeveralInputs(arr);

            int sum = arr[0];

            Console.WriteLine(sum);

            for(int i = 1; i < arr.Count; i++)
            {
                sum += arr[i];
                Console.WriteLine("+ " + arr[i]);
                

            }

            Console.WriteLine("= " + sum);

            arr.Clear();

            Continue();
        }

        // The overloaded method below allows the user to recieve the difference of the inputted integers.
        static void Subtraction(List<int> arr)
        {
            Console.WriteLine("--- Array subtraction ---");

            AskForSeveralInputs(arr);

            // Receive the 
            int difference = arr[0];

           

            Console.WriteLine(difference);

            for (int i = 1; i < arr.Count; i++)
            {
                difference -= arr[i];
                Console.WriteLine("- " + arr[i]);

               

            }

            Console.WriteLine("= " + difference);

            arr.Clear();

            Continue();

        }

        // The console asks the user for a input of number of integers
        static void AskForSeveralInputs(List<int> arr) {

            Console.Write("Enter a number with ints. Separate the ints with a ','.\nThe recently selected operation occurs when entering a second int.\nInputted numbers: ");

            string input = Console.ReadLine();

            string[] split = input.Split(",");

            for (int i = 0; i < split.Length; i++)
            {
                arr.Add(int.Parse(split[i]));
            }
        }
        
    }

}