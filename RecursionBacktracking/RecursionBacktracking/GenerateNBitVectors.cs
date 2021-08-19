using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionBacktracking
{
    class GenerateNBitVectors
    {
        public static void Gen01(int index, int[] vector)
        {
            if (index >= vector.Length)
                Console.WriteLine(string.Join( "",vector));
            else
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Gen01(index + 1, vector);
                }
        }

    }
}
