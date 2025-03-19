using System;
using static System.Console;

namespace Array_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] cages = new string[3][];
            cages[0] = new string[2];
            cages[1] = new string[4];
            cages[2] = new string[1];
            // Floor 1
            cages[0][0] = "Lejon";
            cages[0][1] = "Tiger";
            // Floor 2
            cages[1][0] = "Gnu";
            cages[1][1] = "Horse";
            cages[1][2] = "Giraff";
            cages[1][3] = "Zebra";
            // Floor 3
            cages[2][0] = "Varan";
            foreach (string[] floor in cages)
            {
                foreach (string cage in floor)
                {
                    Write($"{cage}, ");
                }

                WriteLine();
                WriteLine("------------------------");
            }
        }
    }
}
