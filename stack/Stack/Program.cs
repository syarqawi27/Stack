using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            int topStack;

            intStack.Push(50);
            intStack.Push(70);
            intStack.Push(100);
            intStack.Push(20);

            foreach (int i in intStack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("No.element in stack =" +intStack.Count);
            Console.WriteLine("......................" );
            topStack = intStack.Pop();

            foreach (int i in intStack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("No.element in stack =" + intStack.Count);
            Console.WriteLine("The element Popped =" + topStack);
            Console.WriteLine("......................");
            topStack = intStack.Pop();

            foreach (int i in intStack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("No.element in stack =" + intStack.Count);
            Console.WriteLine("The element Popped =" + topStack);
            Console.WriteLine("......................");
            Console.ReadKey();
        }
    }
}
