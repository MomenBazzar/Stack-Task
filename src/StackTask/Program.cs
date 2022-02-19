using System;

namespace StackTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<char>();
            stack.Push('r');
            stack.Push('b');
            stack.Push('q');
            stack.Pop();
            stack.Push('h');
            // stack.Clear();
            stack.Print();
        }
    }
}