namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());// 받은 바이트 크기
            string result = "";

            size /= 4;

            for(int i = 0; i < size; ++i)
            {
                result += "long ";
            }

            Console.WriteLine(result+"int");
        }
    }
}
