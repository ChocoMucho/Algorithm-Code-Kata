namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if(x > 0)
            {
                if(y > 0)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("4");
            }
            else
            {
                if (y > 0)
                    Console.WriteLine("2");
                else
                    Console.WriteLine("3");
            }
        }
    }
}
