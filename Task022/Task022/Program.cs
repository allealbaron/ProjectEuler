using System;
using System.Collections.Generic;
using System.Linq;

namespace Task022
{
    class Program
    {

        /// <summary>
        /// List of names
        /// </summary>
        static readonly List<string> Names = new List<string>();

        /// <summary>
        /// Given a name, returns its value
        /// A=1, B=2, C=3...
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>Value</returns>
        static int GetNameValue(string name)
        {

            int result = 0;

            foreach (char c in name.ToCharArray())
            {
                result += ((int)c - 64);
            }

            return result;

        }

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            string rawFile = System.IO.File.ReadAllText(@"names.txt");

            rawFile = rawFile.Replace('"', ' ').Replace(" ", String.Empty);

            Names.AddRange(rawFile.Split(',').ToList());
            Names.Sort();

            int scores = 0;

            for (int i = 0; i < Names.Count; i++)
            {
                scores += ((i + 1) * GetNameValue(Names[i]));
            }

            Console.WriteLine("Solution: {0}", scores);

        }
    }
}
