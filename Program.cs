using System;
using System.Numerics;

namespace MyParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // let the user determine how many random integer numbers they want to generate
            Console.WriteLine("How many random integer numbers do you want to enter?");
            
            //store number amt response in variable
            int size = int.Parse(Console.ReadLine());
            
            //Create int numbers array
            int[] numbers = new int[size];
            
            //create random object
            Random r = new Random();    
            
            //generate numbers to store in array based on size input from user
            for (int i = 0; i < size; i++)
            {
                numbers[i] =  r.Next(1, 10);
            }
            //print out numbers in the array
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Display randomly generated numbers: {numbers[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Total from add method: {Add(numbers)}");
            Console.WriteLine($"Total from multiply method: {Multiply(numbers)}");
        }
        static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }
        static int Multiply(params int[] numbers)
        {
            int total = 1;
            foreach (int number in numbers)
            {
                total *= number;
            }
            return total;
        }

    }
}