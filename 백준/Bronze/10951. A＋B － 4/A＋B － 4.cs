namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string input = Console.ReadLine();
                if (input != null)
                {
                    string[] strings = input.Split(' ');
                    int a = int.Parse(strings[0]);
                    int b = int.Parse(strings[1]);
                    Console.WriteLine(a + b);
                }
                else 
                    break;
            }
        }
    }
}