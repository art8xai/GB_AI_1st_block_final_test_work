internal class Program
{
    private static void Main(string[] args)
    {
        // A task:
        // Write a program that from the existing array of strings forms an array of strings whose length is less than or equal to 3 symbols.
        // The initial array can be entered from the keyboard, or set at the start of the algorithm execution.
        // When solving, it is not recommended to use collections, it is better to get by with arrays only.
        // Examples:
        // ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
        // ["1234", "1567", "-2", "computer science"] -> ["-2"]
        // ["Russia", "Denmark", "Kazan"] -> []

        // Clear the console from the previous launch of the program.
        Console.Clear();

        // This program consists of a main method and additional methods.

        // The main method that, from an existing array of strings, forms a new array of strings whose length is less than or equal to N symbols.
        string[] GetArrayLessOrEqualSymbolQuantity(string[] arraySource, int symbolQuantity)
        {
            // Step 1. Determining the size of a new array.
            int sizeArrayNew = 0;
            for (int i = 0; i < arraySource.Length; i++)
            {
                if (arraySource[i].Length <= symbolQuantity)
                {
                    sizeArrayNew++;
                }
            }

            // Step 2. Creating a new empty array of the size calculated above.
            var arrayNew = new string[sizeArrayNew];

            // Step 3. Checking each value of the source array.
            // If the value matches the condition by the number of symbols, then this value is written to a new array.
            int j = 0;
            for (int i = 0; i < arraySource.Length; i++)
            {
                if (arraySource[i].Length <= symbolQuantity)
                {
                    arrayNew[j] = arraySource[i];
                    j++;
                }
            }
            return arrayNew;
        }

        // Additional method that defines an array of N elements.
        string[] GetArrayManually(int size)
        {
            var array = new string[size];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    if (array.Length > 1)
                    {
                        Console.Write("Enter the first text: ");
                    }
                    else
                    {
                        Console.Write("Enter text: ");
                    }
                }
                else
                {
                    if (i < array.Length - 1)
                    {
                        Console.Write("Enter the following text: ");
                    }
                    else
                    {
                        Console.Write("Enter the last text: ");
                    }
                }
                array[i] = Console.ReadLine();
            }
            return array;
        }

        // An additional method that displays an array.
        string GetArrayOutput(string[] array)
        {
            string result = "[";
            for (int i = 0; i < array.Length; i++)
            {
                result = result + "\"" + array[i];

                if (i < array.Length - 1)
                {
                    result = result + "\", ";
                }

                if (i == array.Length - 1)
                {
                    result = result + "\"";
                }
            }
            result = result + "]";
            return result;
        }

        try
        {
            // Determining the size of the source array.
            Console.Write("Enter the size of the source array: ");
            int sizeArraySource = Convert.ToInt32(Console.ReadLine());

            // Additional check of the number entered by the user.
            if (sizeArraySource <= 0)
            {
                Console.Write("The input string must be a positive number.");
            }
            else
            {
                // Calling a function (method) and returning the result to a variable.
                var arraySource = GetArrayManually(sizeArraySource);

                // Determining the number of symbols.
                int symbolQuantity = 3;

                // Calling a function (method) and returning the result to a variable.
                var arrayNew = GetArrayLessOrEqualSymbolQuantity(arraySource, symbolQuantity);

                // Displaying the result on the screen.
                Console.WriteLine($"{GetArrayOutput(arraySource)} -> {GetArrayOutput(arrayNew)}");
            }
        }
        catch (Exception ex)
        {
            // Error message output.
            Console.WriteLine(ex.Message);
        }

        // Keep the console window open in debug mode.
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
