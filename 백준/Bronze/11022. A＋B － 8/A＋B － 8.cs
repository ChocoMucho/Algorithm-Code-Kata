namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for(int i = 1; i <= count; ++i)
            {
                string[] strings = Console.ReadLine().Split(' ');
                int a = int.Parse(strings[0]);
                int b = int.Parse(strings[1]);
                Console.WriteLine($"Case #{i}: {a} + {b} = {a+b}");
            }
        }
    }
}
