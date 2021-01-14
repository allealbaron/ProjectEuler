using System;
using System.Linq;

namespace Task009
{
    class Program
    {

        /// <summary>
        /// Max number
        /// </summary>
        private const int MAX_NUMBER = 1000;

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            Int64 result = (from t1 in Enumerable.Range(1, MAX_NUMBER)
                    from t2 in Enumerable.Range(1, MAX_NUMBER)
                    where (t1 < t2) 
                    && (t1 + t2 < MAX_NUMBER)
                    && (Math.Pow(t1,2) + Math.Pow(t2, 2) == Math.Pow((MAX_NUMBER - (t1+t2)),2))
                    select (t1*t2*(MAX_NUMBER - (t1+t2)))).FirstOrDefault();

            Console.WriteLine("Hello World! {0}", result);

        }
    }
}
