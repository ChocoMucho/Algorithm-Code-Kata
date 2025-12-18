namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rcptTotal = int.Parse(Console.ReadLine());//영수증에 적힌 총액
            int num = int.Parse(Console.ReadLine());//반복횟수
            int total = 0;

            for(int i = 0; i < num; ++i)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int price = int.Parse(inputs[0]);
                int amount = int.Parse(inputs[1]);

                total += price * amount;
            }

            if (rcptTotal == total)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
