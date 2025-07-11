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

            #region Video_2
            // EX-1
            int[,] marks = new int[2, 5]
    {
        { 90, 80, 80, 60, 70 },
        { 100, 60, 80, 60, 90 }
    };

            //marks[0, 0] = 0;
            //marks[0, 1] = 10;
            //marks[0, 2] = 20;
            //marks[0, 3] = 30;
            //marks[0, 4] = 50;
            //marks[1, 0] = 0;
            //marks[1, 1] = 10;
            //marks[1, 2] = 20;
            //marks[1, 3] = 30; // This line is cut off in the image but logically follows the pattern
            //marks[1, 4] = 50;

            //EX-2
            // Assuming 'marks' array is declared and initialized from the previous image context:
            // int[,] marks = new int[2, 5]
            // {
            //     { 90, 80, 80, 60, 70 },
            //     { 100, 60, 80, 60, 90 }
            // };

            // The code snippet starts with a loop for printing separators, then clears the console, then prints grades.

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine("===================");
            }

            Console.Clear(); // Clears the console output

            // Print
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine($"The Grades Of Student Number {i + 1}");
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    Console.WriteLine($"The Grade Of Subject Number {j + 1} => {marks[i, j]}");
                }
                Console.WriteLine("===================");
            }
            #endregion
        }
    }
}
