using System;
using System.Collections.Generic;

//Fråga 1:
//Stack och heap är två områden i datorns minne som användas för att lagra data under exekvering av ett program
//Dom har olika egenskapar och användas för olika typer av data.
//stacken användas för att lagra lokala variabler och funktionsanrop,Det är en snabb minne som hanterar minnedsllokering enlight LIFO (last In First Out).
//heapen avnändas för att lagra dynamiskt allokerat minne, som är minne vars storlek och livstid inte är känd på förhand.

//exampel:
//int x = 5; x är en lokal variabel och lagras i stacken
//public class ValueClass
//{
//  public int value;
//}
//ValueClass val = new ValueCalss(); lagras i heapen


// Fråga 2: 
//Value types är typer från System.ValueType som till example: bool, byte, int, long och uint.
//Reference types är typer som ärver från system.Object som till example: class, interface, object, string och delegate.
//Det som skilier dem åt är att reference types lagras alltid på  heapen, medan Value types kan lagras både på stacken eller heapen (lagras där dem deklareras).


//Fråga 3:
//Den första metoden retunerar 3 för att x och y är value types, medan på den andra metoden är x och y referenser för samma object.


namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            bool exitLoop = false;
            while (!exitLoop)
            { 
                Console.WriteLine("Enter an operation (+name to add the name,-name to remove or exit to exit)");
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Enter an operation (+name to add the name,-name to remove or exit to exit)");
                     input = Console.ReadLine();
                }
                else
                {
                    if(input.ToLower() == "exit")
                    {
                        exitLoop = true;
                    }

                    if(input.Length < 2)
                    {
                        Console.WriteLine("User + or - followed by a name");

                    }

                    char nav = input[0];
                    string value = input.Substring(1).Trim();

                    switch (nav) 
                    {
                        case '+':
                            theList.Add(value);
                            Console.WriteLine($"{value} has added to names");
                            break;
                        case '-':
                            if (theList.Remove(value))
                            {
                                Console.WriteLine($"{value} has removed from names");
                            }
                            else
                            {
                                Console.WriteLine($"{value} does not exist in names");

                            }
                            break;
                        default:
                            Console.WriteLine($"You need to start your input with - or +");
                            break ;
                    }

                    Console.WriteLine($"Number of elements in the list: {theList.Count}, Capacity: {theList.Capacity}");
                }

            }
            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            bool exitLoop = false;

            while (!exitLoop)
            {
              Queue<string> queue = new Queue<string>();
                Console.WriteLine("Ica opens and the queue is empty.");
                    Console.WriteLine("The queue is empty.");
           
                    queue.Enqueue("Kalle");
                    Console.WriteLine("Kalle joins the queue.");
                    Console.WriteLine($"Current queue: {string.Join(", ", queue)}");
                    Console.WriteLine("----------------------------------------------------");
                    queue.Enqueue("Greta");
                    Console.WriteLine("Greta joins the queue.");
                    Console.WriteLine($"Current queue: {string.Join(", ", queue)}");
                    Console.WriteLine("----------------------------------------------------");
                    queue.Dequeue();
                    Console.WriteLine("Kalle left the queue.");
                    Console.WriteLine($"Current queue: {string.Join(", ", queue)}");
                    Console.WriteLine("----------------------------------------------------");
                    queue.Enqueue("Stina");
                    Console.WriteLine("Stina joins the queue.");
                    Console.WriteLine($"Current queue: {string.Join(", ", queue)}");
                    Console.WriteLine("----------------------------------------------------");
                    queue.Dequeue();
                    Console.WriteLine("Greta left the queue.");
                    Console.WriteLine($"Current queue: {string.Join(", ", queue)}");
                    Console.WriteLine("----------------------------------------------------");
                    queue.Enqueue("Olle");
                    Console.WriteLine("Olle joins the queue.");
                    Console.WriteLine($"Current queue: {string.Join(", ", queue)}");
                    Console.WriteLine("----------------------------------------------------");
                    
                    Console.WriteLine("Enter exit to exit)");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Enter exit to exit)");
                        input = Console.ReadLine();
                    }

                    if(input.ToLower() == "exit")
                    {
                        exitLoop = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter exit to exit)");
                        input = Console.ReadLine();
                    }
            };

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            bool exitLoop = false;

            while (!exitLoop) 
                {
                    Console.WriteLine("Write a text to reverse.");
                    string text = Console.ReadLine();
                    if (string.IsNullOrEmpty(text))
                    {
                        Console.WriteLine("Enter exit to exit)");
                        text = Console.ReadLine();
                    }

                    Stack<char> stack = new Stack<char>();

                    foreach (char c in text)
                    {
                        stack.Push(c);
                    }

                    string reversed = string.Empty;
                    while (stack.Count > 0)
                    {
                        reversed += stack.Pop();
                    }

                    Console.WriteLine($"The reversd text: {reversed}");

                    Console.WriteLine("Enter exit to exit)");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Enter exit to exit)");
                        input = Console.ReadLine();
                    }

                    if (input.ToLower() == "exit")
                    {
                        exitLoop = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter exit to exit)");
                        input = Console.ReadLine();
                    }
                };

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            Console.WriteLine("Enter a text to check if it's correct.");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Enter a text to check if it's correct.");
                input = Console.ReadLine();
            }
            bool result = CheckTheString(input);

            Console.WriteLine("----------------------------------------------------");
            if (result)
            {
                Console.WriteLine("Currect!");
            }
            else
            {
                Console.WriteLine("Incurrect!");
            }
            Console.WriteLine("----------------------------------------------------");

        }

         static bool CheckTheString(string? input)
        {
            Stack<char> chars = new Stack<Char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    chars.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (chars.Count == 0)
                    {
                       return false;
                    }

                    char top = chars.Pop();

                    if ((ch == ')' && top != '(') || (ch == '}' && top != '{') || (ch == ']' && top != '['))
                    {
                       return false;
                    }
                }

            }
            return chars.Count == 0;
        }

    }
}

