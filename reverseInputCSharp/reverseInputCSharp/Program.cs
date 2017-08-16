using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseInputCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // provide instruction
            Console.WriteLine("Enter a sentence and I will reverse it!");

            // create variable to hold input
            string input = Console.ReadLine();

            // tokenize input string
            string[] tokens = input.Split(' ');

            // create new stringBuilder object
            StringBuilder sb = new StringBuilder();

            // create for loop 
            for (int index = tokens.Length - 1; index > -1; index--)
            {
                sb.Append(tokens[index]);
                sb.Append(" ");
            }

            // display new string
            Console.WriteLine(sb);

            // hold screen open
            Console.ReadLine();
        }
    }
}
