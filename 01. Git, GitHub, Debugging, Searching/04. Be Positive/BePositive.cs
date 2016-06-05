using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Be_Positive
{
    class BePositive
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());
            char[] delimereters = new char[] { ' ' };

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Split(delimereters, StringSplitOptions.RemoveEmptyEntries);
                List<int> numbers = (from t in input where !t.Equals(string.Empty) select int.Parse(t)).ToList();

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else
                    {
                        if (j < numbers.Count-1)
                        {
                        currentNum += numbers[++j];
                        }

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
