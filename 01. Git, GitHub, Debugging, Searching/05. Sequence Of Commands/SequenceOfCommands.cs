using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_Of_Commands
{
    class SequenceOfCommands
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] line = Console.ReadLine().Split(ArgumentsDelimiter);
            string command = line[0];

            while (!command.Equals("stop"))
            {
                //string line = Console.ReadLine().Trim();
                int[] args = new int[2];

                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply"))
                {
                    string[] stringParams = { line[1], line[2] };
                    args[0] = int.Parse(stringParams[0]);
                    args[1] = int.Parse(stringParams[1]);

                    PerformAction(array, command, args);
                }

                array = PerformAction(array, command, args);

                PrintArray(array);
                Console.WriteLine();

                line = Console.ReadLine().Split(ArgumentsDelimiter);
                command = line[0];
            }
        }

        static long[] PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos - 1] *= value;
                    break;
                case "add":
                    array[pos - 1] += value;
                    break;
                case "subtract":
                    array[pos - 1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
            return array;
        }

        private static void ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length-1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                
                array[i] = array[i + 1];
            }
            array[array.Length-1] = temp;
        }

        private static void PrintArray(long[] array)
        {
            foreach (long t in array)
            {
                Console.Write(t + " ");
            }
        }
    }
}
