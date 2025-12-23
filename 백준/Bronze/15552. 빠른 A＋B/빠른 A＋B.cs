using System;
using System.Text;

namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb= new StringBuilder();
            int size = int.Parse(Console.ReadLine());// count

            for(int i = 0; i < size; ++i)
            {
                string[] strings = Console.ReadLine().Split(' ');
                sb.Append(int.Parse(strings[0]) + int.Parse(strings[1]));
                sb.Append('\n');
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
