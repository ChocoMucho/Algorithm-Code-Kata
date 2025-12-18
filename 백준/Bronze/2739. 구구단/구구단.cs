namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= 9; ++i)
            {
                Console.WriteLine($"{num} * {i} = {num*i}");
            }
        }
    }
}
