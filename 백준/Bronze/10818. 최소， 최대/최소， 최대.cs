namespace BAEKJOON_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] inputs = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; ++i)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            Console.WriteLine($"{FindMin(arr, true)} {FindMin(arr, false)}");

        }

        static int FindMin(int[] arr, bool isMin)
        {
            int returnValue = 0;
            if(isMin)
            {
                int min = int.MaxValue;
                for(int i = 0; i < arr.Length; ++i)
                {
                    if(min > arr[i])
                        min = arr[i];
                }
                returnValue = min;
            }
            else
            {
                int max = int.MinValue;
                for(int i = 0; i < arr.Length; ++i)
                {
                    if (max < arr[i])
                        max = arr[i];
                }
                returnValue = max;
            }

            return returnValue;
        }
    }
}