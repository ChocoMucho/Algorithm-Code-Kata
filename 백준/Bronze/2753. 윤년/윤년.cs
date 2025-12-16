namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputYear = 0;
            string input = Console.ReadLine();
            inputYear = int.Parse(input);

            // 조건: 4의 배수는 됨, 100의 배수는 안됨, 400의 배수는 됨
            if(inputYear%4 == 0)
            {
                if(inputYear%400 == 0)
                {
                    Console.WriteLine(1);
                    return;
                }
                else if(inputYear%100 == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
                else
                {
                    Console.WriteLine(1);
                    return;
                }
            }
            
            Console.WriteLine(0);
        }
    }
}
