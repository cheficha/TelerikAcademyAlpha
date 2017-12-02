using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigShiftMatrix
{

    class Program
    {
        static int Rows;
        static int Cols;
        static void Main(string[] args)
        {
            Rows = int.Parse(Console.ReadLine());
            Cols = int.Parse(Console.ReadLine());
            var Moves = int.Parse(Console.ReadLine());
            var matrix = new BigInteger[Rows, Cols];
            fillTheMatrix(matrix);

        }

        private static void fillTheMatrix(BigInteger[,] fill)
        {

        }
    }
}
