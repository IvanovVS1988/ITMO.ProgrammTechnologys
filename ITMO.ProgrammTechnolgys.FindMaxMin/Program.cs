using System;

namespace ProgrammTechnologys.FindMaxMin
{
    class Program
    {
        static void FindMaxMin(double[] M, out double MAX, out double MIN)
        {
            int i;
            MAX = M[0];
            MIN = M[0];
            for (i = 1; i < M.Length; i++)
            {
                if (M[i] > MAX)
                    MAX = M[i];
                else if (M[i] < MIN)
                    MIN = M[i];
            }
        }
        static void Main(string[] args)
        {
        }
    }
}