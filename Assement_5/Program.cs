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
        }
    }
}
