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
    }
}
