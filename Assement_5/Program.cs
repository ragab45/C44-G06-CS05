namespace Assement_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q-1
            Console.Write("Enter size of identity matrix: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(i == j ? "1 " : "0 ");
                }
                Console.WriteLine();
                #endregion
            }
            #region Q-2
            int[] arr = { 2, 4, 6, 8, 10 };
            int sum = 0;

            foreach (int num in arr)
                sum += num;

            Console.WriteLine($"Sum of array elements: {sum}");
            #endregion
            #region Q-3
            int[] arr1 = { 2, 4, 6 };
            int[] arr2 = { 1, 3, 5 };
            int[] merged = new int[arr1.Length + arr2.Length];

            arr1.CopyTo(merged, 0);
            arr2.CopyTo(merged, arr1.Length);

            Array.Sort(merged);
            Console.WriteLine("Merged and sorted array: " + string.Join(", ", merged));
            #endregion
            #region Q-4
            int[] arr = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };
            int max = arr[0], min = arr[0];

            foreach (int val in arr)
            {
                if (val > max) max = val;
                if (val < min) min = val;
            }

            Console.WriteLine($"Max: {max}, Min: {min}");
            #endregion
            #region Q-5
            int[] arr = { 10, 20, 30, 40, 50, 50 };
            int largest = int.MinValue, second = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    second = largest;
                    largest = num;
                }
                else if (num > second && num != largest)
                {
                    second = num;
                }
            }

            Console.WriteLine($"Second largest: {second}");
            #endregion
            #region Q-6
            Console.Write("Enter array elements (space separated): ");
            string[] input = Console.ReadLine().Split();
            int[] arr = Array.ConvertAll(input, int.Parse);

            Dictionary<int, int> firstIndex = new();
            int maxDistance = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (firstIndex.ContainsKey(arr[i]))
                {
                    int distance = i - firstIndex[arr[i]] - 1;
                    if (distance > maxDistance)
                        maxDistance = distance;
                }
                else
                {
                    firstIndex[arr[i]] = i;
                }
            }

            Console.WriteLine($"Longest distance between two equal cells: {maxDistance}");
        }
        #endregion  

    }
}
}
