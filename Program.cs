using System;

namespace SimpleTextBasedRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool q1 = false;
            bool q2 = false;
            bool q3 = false;
            
            Console.WriteLine("Welcome doctor in training to the world of medicine!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Mr. {name}, before you can become a doctor you must pass one final exam.");
            Console.WriteLine("We will begin the examination at once good luck!");
            
            if (name == "Aidan")
            {
                Console.WriteLine("You can't be dr your are imposter");
                return;
            }

            Console.WriteLine("Question 1: What is the powerhouse of the cell?");
            Console.WriteLine("A The Mitochondria");
            Console.WriteLine("B The Nucleus");
            Console.WriteLine("C The Heart");
            string a1 = Console.ReadLine().ToUpper();

            Console.WriteLine("Question 2: What are the first 5 digits of Pi?");
            Console.WriteLine("A 3.1415");
            Console.WriteLine("B 3.1414");
            Console.WriteLine("C 3.1419");
            string a2 = Console.ReadLine().ToUpper();

            Console.WriteLine("Question 3: What is my favorite color?");
            Console.WriteLine("A Red");
            Console.WriteLine("B Blue");
            Console.WriteLine("C Yellow");
            string a3 = Console.ReadLine().ToUpper();

            if (a1 == "A")
            {
                q1 = true;
            }
            if (a2 == "A")
            {
                q2 = true;
            }
            if (a3 == "A")
            {
                q3 = true;
            }

            Console.WriteLine(q1 && q2 && q3 ? $"Congratulations, you are now a doctor, Dr. {name}!" : 
                                               $"I'm sorry Mr. {name}, but I am afraid that it is too soon for you to become a doctor.");
            Console.Read();
        }
    }
}