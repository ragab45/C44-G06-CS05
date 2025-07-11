namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video_1
           // EX-1
            int[] numbers;

            //Console.WriteLine(numbers[0]);
            numbers = new int[3];

            // Initialize With Default Value [0, 0, 0]
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            // [10, 20, 30]
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            // EX- 2
            int[] numbeers; // Assuming 'numbers' array is declared and initialized earlier in the actual code.
                           // For this snippet, let's re-initialize it to match the context.
            numbers = new int[3];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            // [10, 20, 30]
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            //Console.WriteLine($"Size Of Array => {numbers.Length}");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            #endregion;
        }
    }
}
