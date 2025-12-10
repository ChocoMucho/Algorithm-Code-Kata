namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // '-'를 기준으로 분리
            string[] parts = input.Split('-'); // +로 뭉쳐진 덩어리만 남음

            int result = 0;
            foreach (var item in parts[0].Split('+'))
            {
                result += int.Parse(item);
            }

            if(parts.Length > 1)
            {
                // parts[1] 부터 돌면서 +로 묶인 덩어리를 합친 값을 result에서 빼기
                for (int i = 1; i < parts.Length; ++i)
                {
                    int temp = 0;
                    foreach (var item in parts[i].Split('+'))
                    {
                        temp += int.Parse(item);
                    }

                    result -= temp;
                }
            }

            Console.WriteLine(result);
        }
    }
}
