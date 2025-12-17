namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int h = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            // 입력된 분에서 45뺐을 때 마이너스인지
            if (m - 45 < 0)
            {
                m = 60 - (45 - m);
                if (h == 0)
                    h = 23;
                else
                    h -= 1;
            }
            else
            {
                m -= 45;
            }

            Console.WriteLine($"{h} {m}");
        }
    }
}
