namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            string[] strings = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[amount];
            for (int i = 0; i < amount; ++i)
            {
                numbers[i] = int.Parse(strings[i]);
            }

            Console.WriteLine(CountNumbers(numbers, n));
        }

        static int CountNumbers(int[] numbers, int n)
        {
            int amount = numbers.Length;
            int count = 0;
            for (int i = 0; i < amount; ++i)
            {
                if (numbers[i] == n) ++count;
            }
            return count;
        }
    }
}