namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] result = new int[num];

            for(int i = 0; i < num; ++i)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                result[i] = a + b;
            }

            for(int i = 0; i < num; ++i)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
