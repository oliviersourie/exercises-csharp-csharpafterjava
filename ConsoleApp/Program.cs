using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string stop = "STOP";
            string inputText = string.Empty;
            Dictionary<string, int> frequencyTable = new();

            do
            {
                inputText = Console.ReadLine();
                if (inputText != stop)
                {
                    if (frequencyTable.TryGetValue(inputText, out int currentValue))
                    {
                        frequencyTable[inputText] = ++currentValue;
                    }
                    else
                    {
                        frequencyTable.Add(inputText, 1);
                    }
                }
            } while (inputText != stop);

            foreach (KeyValuePair<string, int> text in frequencyTable)
            {
                Console.WriteLine($"{text.Key}: {text.Value}");
            }

            //with LINQ: you can leave out the test on 'stop' in the do...while above
            //foreach (KeyValuePair<string, int> text in frequencyTable.Where(x => x.Key is not stop))
            //{
            //    Console.WriteLine($"{text.Key}: {text.Value}");
            //}

        }
    }
}
