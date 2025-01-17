﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiagonalDifference
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int LeftToRightDiagonalSum = 0;
            int RightToLeftDiagonalSum = 0;

            for(int i = 0; i < arr.Count(); i++)
            {
                LeftToRightDiagonalSum += arr[i][i];
                RightToLeftDiagonalSum += arr[i][arr.Count() - 1 - i];
            }

            int diagonalDifference = LeftToRightDiagonalSum - RightToLeftDiagonalSum;

            return Math.Abs(diagonalDifference);

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
