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
            int cookTime = int.Parse(Console.ReadLine()); // 

            // 입력된 분을 시간과 분 단위로 변경
            int cookTimeH = cookTime / 60;
            int cookTimeM = cookTime % 60;

            if (m + cookTimeM >= 60)
            {
                m = (m + cookTimeM) % 60;
                h = (h + cookTimeH + 1) % 24;
            }
            else
            {
                m += cookTimeM;
                h = (h + cookTimeH) % 24;
            }
            

            Console.WriteLine($"{h} {m}");
        }
    }
}
