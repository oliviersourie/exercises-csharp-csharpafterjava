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
            string inputText;
            Dictionary<string, int> frequencyTable = new();

            do
            {
                inputText = Console.ReadLine().Trim();
                if (inputText is not stop)
                {
                    foreach (string inputWord in inputText.Split(" "))
                    {
                        if (frequencyTable.TryGetValue(inputWord, out int currentValue))
                        {
                            frequencyTable[inputWord] = ++currentValue;
                        }
                        else
                        {
                            frequencyTable.Add(inputWord, 1);
                        }
                    }                    
                }
            } while (inputText is not stop);

            foreach (KeyValuePair<string, int> text in frequencyTable)
            {
                Console.WriteLine($"{text.Key}: {text.Value}");
            }

            //with LINQ
            //frequencyTable.Where(text => text.Key is not stop)
            //              .ToList()
            //              .ForEach(text => Console.WriteLine($"{text.Key}: {text.Value}"));

        }
    }
}
