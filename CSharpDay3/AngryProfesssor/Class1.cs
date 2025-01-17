﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AngryProfesssor
{
    class Result
    {

        /*
         * Complete the 'angryProfessor' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY a
         */

        public static string angryProfessor(int k, List<int> a)
        {
            string lecture = "";
            int count = 0;

            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] <= 0)
                {
                    count++;
                }
            }

            if (count < k)
            {
                lecture = "YES";
            }
            else
            {
                lecture = "NO";
            }
            return lecture;
        }


    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int k = Convert.ToInt32(firstMultipleInput[1]);

                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                string result = Result.angryProfessor(k, a);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
