namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');
            int n = int.Parse(strings[0]);
            int x = int.Parse(strings[1]);

            string[] numStrings = Console.ReadLine().Split(' ');
            int[] nums = new int[n];
            for(int i = 0; i < n; ++i)
            {
                nums[i] = int.Parse(numStrings[i]);
            }

            PrintLessX(x, nums);
        }

        static void PrintLessX(int x, int[] nums)
        {
            int n = nums.Length;
            for(int i = 0; i < n; ++i)
            {
                if (nums[i] < x)
                    Console.Write(nums[i] + " ");
            }
        }
    }
}