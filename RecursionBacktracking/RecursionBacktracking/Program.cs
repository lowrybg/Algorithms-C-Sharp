using System;

namespace RecursionBacktracking
{
    class Program
    {
        static int Sum(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }
            var sum = Sum(array, index + 1);
            return array[index] + sum;
        }

        static void Main(string[] args)
        {
            //var numbers = new[] {0*8 };

            //console.writeline(sum(numbers, 0));
            //recursivedrawing.printfigure(5);
            
            var vector = new int[8];
            GenerateNBitVectors.Gen01(0, vector);

        }



    }
}
