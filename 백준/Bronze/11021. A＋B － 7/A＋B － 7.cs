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
                Console.WriteLine($"Case #{i}: {int.Parse(strings[0])+int.Parse(strings[1])}");
            }
        }
    }
}
