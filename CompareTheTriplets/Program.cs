using System;
using System.Collections.Generic;

namespace CompareTheTriplets
{
    class Solution
    {
        /*
           CompareTriplets solves the problem outlined at
           https://www.hackerrank.com/challenges/compare-the-triplets/problem
        */

        static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int a_win = 0;
            int b_win = 0;
            List<int> results = new List<int>();

            for (int i = 0; i < a.Count - 1; i++)
            {
                if (a[i] > b[i])
                {
                    a_win++;
                }
                else if (a[i] < b[i])
                {
                    b_win++;
                }
            }
            results.Add(a_win);
            results.Add(b_win);
            return results;

        }
    }
}
