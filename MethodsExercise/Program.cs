using System.Globalization;
using System.Runtime.InteropServices.JavaScript;

namespace MethodsExercise
{
    public class Program
    {
        public static void Interrogation()
        {
            Console.WriteLine("Hello, I am Detective Jones. This is Detective Tucker.  We just have a few questions" +
                              "for you. Let's start with your Name, please?");
            string name = Console.ReadLine();
            Console.WriteLine($"Thank you {name}, Where were you at Midnight last night?");
            string place = Console.ReadLine();
            Console.WriteLine("And, Who were you with?");
            string alibi = Console.ReadLine();
            Console.WriteLine($"Well that's an interesting story! Because we checked your phone's gps and it doesn't" +
                              $" show you any where near {place} at Midnight. And we already talked to {alibi} and they" +
                              $" were at the Casino, on camera.  You were nowhere to be seen. Would you like to confess" +
                              $" now?");
            
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double Divide(int firstNumber, int secondNumber)
        {
            return (double)firstNumber / secondNumber;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            
            return sum;
        }

        public static void PickaNumber()
        {
            Console.WriteLine("Please choose a number between 1 and 100");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank you, Please choose another number between 1 and 100");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Thank you. Those numbers added up equal: {Add(firstNumber, secondNumber)}");
            
            Console.WriteLine($"I can also do subtraction. {firstNumber} minus {secondNumber} equals" +
                              $" {Subtract(firstNumber, secondNumber)}");
            
            Console.WriteLine($"Let's try and multiple them together.  I think the answer is" +
                              $" {Multiply(firstNumber, secondNumber)}");
            
            Console.WriteLine($"Division doesn't always come out to a whole number so we may get a decimal. " +
                              $" {firstNumber} divided by {secondNumber} equals: {Divide(firstNumber, secondNumber)}");
            
            Console.WriteLine("For my final trick please pick another number?");
            int thirdNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Thank for that.  Those 3 numbers added all together sum up to be: {Sum(thirdNumber, secondNumber, firstNumber)} ");
            

        }

        static void Main(string[] args)
        {
            Interrogation();
            PickaNumber();
        }
        
    }
    
}
