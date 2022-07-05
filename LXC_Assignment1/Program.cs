// See https://aka.ms/new-console-template for more information

// Declaration of first and second variables so they can be assigned throughout the program. 

namespace LXC_Assignment1
{
    public class Program
    {

        static List<int> array = new List<int>();

        public Program()
        {
            
        }

        public static void Main(string[] args)
        {
            Menu();
        }

        static double first, second;

        // Use the menu method.
        


        // The method below allows the user to enter two different integers and receive the sum of them. 
        public static double Addition(double first, double second)
        {

            double sum = first + second;

            Console.WriteLine(first + " + " + second + " = " + sum);
            

            return sum;
        }

        // The method below allows the user to recieve the difference of two inputted integers.
        public static double Subtraction(double first, double second)
        {

            double difference = first - second;

            Console.WriteLine(first + " - " + second + " = " + difference);

            return difference;

        }

        // The method below allows the user receive the product of two inputted integers. 
        public static double Multiplication(double first, double second)
        {

            double product = first * second;

            Console.WriteLine(first + " * " + second + " = " + product);

            return product;
        }

        // The method below allows the user to receive the fraction of the numerator and the denomirator. 
        public static double Division(double first, double second)
        {

            double fraction = first / second;
            if (second != 0)
            {
                fraction = first / second;
                Console.WriteLine(first + " / " + second + " = " + fraction);
            }
            else
            {
                Console.WriteLine("The second int must not be 0. Try again.");
                
            }
            return fraction;
        }



        // The menu. 
        public static void Menu()
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

                    AskForInput(out first, out second);
                    Addition(first, second);
                    Continue();
                    break;

                case 2:

                    AskForInput(out first, out second);
                    Subtraction(first, second);
                    Continue();
                    break;

                case 3:

                    AskForInput(out first, out second);
                    Multiplication(first, second);
                    Continue();
                    break;

                case 4:

                    AskForInput(out first, out second);
                    Division(first, second);
                    Continue();
                    break;

                case 5:
                    AskForSeveralInputs(array);
                    Addition(array);
                    Continue();
                    break;

                case 6:
                    AskForSeveralInputs(array);
                    Subtraction(array);
                    Continue();
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
        public static bool Continue()
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
        public static void AskForInput(out double first, out double second)
        {

                
                Console.Write("Enter first int: ");

                first = Convert.ToDouble(Console.ReadLine());

            

                Console.Write("Enter second int: ");

                second = Convert.ToDouble(Console.ReadLine());
           
        }


        // The overloaded method below allows the user to enter a number different integers and receive the sum of them. 
        public static int Addition(List<int> arr)
        {
            Console.WriteLine("--- Array addition ---");
            

            int sum = arr[0];

            Console.WriteLine(sum);

            for(int i = 1; i < arr.Count; i++)
            {
                sum += arr[i];
                Console.WriteLine("+ " + arr[i]);
                

            }

            
            Console.WriteLine("= " + sum);

            return sum;


        }

        // The overloaded method below allows the user to recieve the difference of the inputted integers.
        public static int Subtraction(List<int> arr)
        {
            Console.WriteLine("--- Array subtraction ---");

            

            // Receive the 
            int difference = arr[0];

           

            Console.WriteLine(difference);

            for (int i = 1; i < arr.Count; i++)
            {
                difference -= arr[i];
                Console.WriteLine("- " + arr[i]);

               

            }

            

            Console.WriteLine("= " + difference);
            return difference;
            //arr.Clear();



        }

        // The console asks the user for a input of number of integers
        public static List<int> AskForSeveralInputs(List<int> arr) {
            
            Console.Write("Enter a number with ints. Separate the ints with a ','.\nThe recently selected operation occurs when entering a second int.\nInputted numbers: ");

            string input = Console.ReadLine();

            string[] split = input.Split(",");

            for (int i = 0; i < split.Length; i++)
            {
                arr.Add(int.Parse(split[i]));
            }

            return arr;
        }
        
    }

}