using System;
using System.Collections.Generic;

namespace Task018
{
    class Program
    {
        static void Main()
        {
            /*
            Triangles.Add(new List<int>() { 3 });
            Triangles.Add(new List<int>() { 7,4 });
            Triangles.Add(new List<int>() { 2,4,6 });
            Triangles.Add(new List<int>() { 8, 5, 9, 3 });
            */

            List<List<int>> Triangles = new List<List<int>>();

            Triangles.Add(new List<int>() { 75 });
            Triangles.Add(new List<int>() { 95, 64 });
            Triangles.Add(new List<int>() { 17, 47, 82 });
            Triangles.Add(new List<int>() { 18, 35, 87, 10 });
            Triangles.Add(new List<int>() { 20, 04, 82, 47, 65 });
            Triangles.Add(new List<int>() { 19, 01, 23, 75, 03, 34 });
            Triangles.Add(new List<int>() { 88, 02, 77, 73, 07, 63, 67 });
            Triangles.Add(new List<int>() { 99, 65, 04, 28, 06, 16, 70, 92 });
            Triangles.Add(new List<int>() { 41, 41, 26, 56, 83, 40, 80, 70, 33 });
            Triangles.Add(new List<int>() { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 });
            Triangles.Add(new List<int>() { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 });
            Triangles.Add(new List<int>() { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 });
            Triangles.Add(new List<int>() { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 });
            Triangles.Add(new List<int>() { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 });
            Triangles.Add(new List<int>() { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 });
          
            for (int i = Triangles.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Triangles[i][j] += Math.Max(Triangles[i + 1][ j], Triangles[i + 1][ j + 1]);
                }
            }

            Console.WriteLine("Solution: {0}", Triangles[0][0]);

        }
    }
}

