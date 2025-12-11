namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int citieCount = 0;
            int[] distances;
            int[] oilPrices;
            int minPrice = int.MaxValue;
            int result = 0;

            string input = Console.ReadLine();
            citieCount = int.Parse(input);
            distances = new int[citieCount - 1];
            oilPrices = new int[citieCount];

            input = Console.ReadLine(); // 거리 입력
            string[] strings = input.Split(' ');
            for(int i = 0; i < citieCount - 1; ++i)
            {
                distances[i] = int.Parse(strings[i]);
            }

            input = Console.ReadLine(); // 리터당 가격 입력
            strings = input.Split(' ');
            for (int i = 0; i < citieCount; ++i)
            {
                oilPrices[i] = int.Parse(strings[i]);
            }
            
            minPrice = oilPrices[0];
            for(int i = 0; i < citieCount - 1; ++i) // 도시별 기름 값 비교 및 주유
            {
                if(minPrice > oilPrices[i])
                    minPrice = oilPrices[i]; // 더 작은 경우 최솟값 갱신
                result += minPrice * distances[i];
            }

            Console.WriteLine(result);
        }
    }
}
