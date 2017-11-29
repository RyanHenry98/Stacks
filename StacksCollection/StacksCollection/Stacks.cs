using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StackCollections
{
    class Program
    {
        public static void Main()
        {
            Stack<string> Stack = new Stack<string>();
            bool flag = false;
            do
            {
                int userChoice = 0;
                Console.WriteLine(" Choose an operation to carry out on the stack. \n  0 - End. \n  1 - Push. \n  2 - Pop. \n  3 - Peek. \n  4 - Clear. \n  5 - Search. \n  6 - Display. \n  7 - Count. ");
                try
                {
                    userChoice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    userChoice = 99;
                }
                if (userChoice == 1)
                {
                    Push(Stack);
                }
                else if (userChoice == 2)
                {
                    Pop(Stack);
                }
                else if (userChoice == 3)
                {
                    Peek(Stack);
                }
                else if (userChoice == 4)
                {
                    Clear(Stack);
                }
                else if (userChoice == 5)
                {
                    Search(Stack);
                }
                else if (userChoice == 6)
                {
                    PrintStack(Stack);
                }
                else if (userChoice == 7)
                {
                    Count(Stack);
                }
                else if (userChoice == 0)
                {
                    Console.WriteLine(" Program End: ");
                    flag = true;
                }
                else
                {
                    Console.WriteLine("   Invalid choice. ");
                }
            }
            while (flag == false);
        }

        public static void PrintStack(Stack<string> Stack)
        {
            int currentIndex = 1;
            if (Stack.Count == 0)
            {
                Console.WriteLine(" The stack is empty. ");
            }
            else
            {
                Console.WriteLine(" All values in the stack: ");
                foreach (string number in Stack)
                {
                    Console.WriteLine(" Value at stack row " + currentIndex + " is " + number + ". ");
                    currentIndex++;
                }
            }
        }
        public static void Push(Stack<string> Stack)
        {
            try
            {
                int pushValue = 0;
                Console.WriteLine(" Push: Enter a value to add to the stack:");
                pushValue = Convert.ToInt32(Console.ReadLine());
                Stack.Push(pushValue.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Invalid value. Try again. ");
                Push(Stack);
            }
        }
        public static void Pop(Stack<string> Stack)
        {
            if (Stack.Count != 0)
            {
                Console.WriteLine(" Pop: The value {0} has been removed from the stack. ", Stack.Pop());
            }
            else
            {
                Console.WriteLine(" Pop: Cannot pop a value; the stack is empty. ");
            }
        }
        public static void Peek(Stack<string> Stack)
        {
            if (Stack.Count != 0)
            {
                Console.WriteLine(" Peek: Next value in stack: {0}", Stack.Peek() + ". ");
            }
            else
            {
                Console.WriteLine(" Peek: No next value; the stack is empty. ");
            }
        }
        public static void Search(Stack<string> Stack)
        {
            try
            {
                int searchValue = 0;
                Console.WriteLine(" Enter a value to search for in the stack. ");
                searchValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" MainStack.Contains(\"" + searchValue + "\") = {0}", Stack.Contains(searchValue.ToString()) + ". ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Invalid value. Try again. ");
                Search(Stack);
            }
        }
        public static void Clear(Stack<string> Stack)
        {
            Console.WriteLine(" Stack cleared. ");
            Stack.Clear();
        }
        public static void Count(Stack<string> Stack)
        {
            Console.WriteLine(" Values in the stack: {0}", Stack.Count + ". ");
        }
    }
}