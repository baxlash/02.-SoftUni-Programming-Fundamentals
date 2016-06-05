using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == search)
                {
                    hasMatch = true;

                    int length = jump+1;



                    if (i+length >= text.Length)
                    {
                        length = text.Length-i;
                    }

                    string matchedString = text.Substring(i, length);
                    Console.WriteLine(matchedString);
                    i += length-1;


                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
