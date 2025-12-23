namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] strings = Console.ReadLine().Split(' ');
                int a = int.Parse(strings[0]);
                int b = int.Parse(strings[1]);

                if (a == 0 & b == 0) break;

                Console.WriteLine(a+b);
            }
        }
    }
}