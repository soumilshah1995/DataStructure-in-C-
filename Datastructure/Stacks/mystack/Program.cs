using System;

namespace mystack
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var stack  = new Stacks<int>();
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);

            System.Console.WriteLine(String.Format("Stack size {0}", stack.Size()));


        }
    }
}
