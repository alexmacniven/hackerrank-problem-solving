/*
 * Solves the Diagonal Difference problem hosted at
 * https://www.hackerrank.com/challenges/diagonal-difference/problem
 */

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the diagonalDifference function below.
    static int DiagonalDifference(int[][] arr)
    {
        int left = 0;
        int right = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            /* Given a square matrix of:
             * 
             *  1 2 3
             *  4 5 6
             *  7 8 9
             *  
             *  'i' will iterate down the rows
             *  
             *  'left' will be the result of row1:column1, row2:column2, row3:column3
             *  'right' will be the result of row1:column3, row2:column2, row3:column1
             */ 
       
            left = left + arr[i][i];
            right = right + arr[i][arr.Length - i - 1];
        }
        // Returns the absolute value;
        // ie. Converts negative to positive
        return Math.Abs(left - right);
    }

    static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = DiagonalDifference(arr);

        // textWriter.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
