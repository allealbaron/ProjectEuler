using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Task067
{
    class Program
    {
        static void Main()
        {
            List<List<int>> Triangles = new List<List<int>>();

            const Int32 BufferSize = 128;
            FileStream fs = File.OpenRead("triangle.txt");
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8, true, BufferSize);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] items = line.Split(' ');

                Triangles.Add((from i in items select int.Parse(i)).ToList<int>());

            }

            sr.Close();
            fs.Close();

            for (int i = Triangles.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Triangles[i][j] += Math.Max(Triangles[i + 1][j], Triangles[i + 1][j + 1]);
                }
            }

            Console.WriteLine("Solution: {0}", Triangles[0][0]);

        }
    }
}
