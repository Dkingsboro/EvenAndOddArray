using static System.Console;
namespace EvenAndOddArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size; // Decalares user input variable for array size

            WriteLine("Separate odd and even integers in separate arrays:");
            WriteLine("----------------------------------------------------");
            Write("Input the number of elements to be stored in the array: ");
            size = int.Parse(ReadLine());

            WriteLine("Input {0} elements in the array:", size); // Gets user input for array

            int[] values = new int[size];

            for (int i = 0; i < size; i++) // Allows user to enter values in array
            {
                Write("Element - {0}: ", i);
                values[i] = int.Parse(ReadLine());
            }

            WriteLine("The original array of elements are: "); // Prints out original array
            foreach (int i in values)
            {
                Write(i + " ");
            }

            WriteLine();

            int[] evenArray = new int[values.Length]; // Copies original array for new even array

            for (int i = 0; i < values.Length; i++)
            {
                evenArray[i] = values[i];
            }

            Array.Sort(evenArray);
            Array.Reverse(evenArray); // Reverses order of evenArray for output

            WriteLine("The Even elements are: "); // Outputs even elements
            foreach (int i in evenArray)
            {
                if (i % 2 == 0)
                {
                    Write(i + " ");
                }
            }

            int[] oddArray = new int[values.Length]; // Copies original array for new odd array
            for (int i = 0; i < values.Length; i++)
            {
                oddArray[i] = values[i];
            }

            WriteLine();

            Array.Sort(oddArray); // Sorts the odd array
            Array.Reverse(oddArray); // Reverses order of odd Array for output

            WriteLine("The Odd elements are: "); // Outputs odd elements
            foreach (int i in oddArray)
            {
                if (i % 2 == 1)
                {
                    Write(i + " ");
                }
            }

        }
    }
}