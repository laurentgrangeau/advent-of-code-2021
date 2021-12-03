using System;
using System.IO;

namespace aocday1 {
    class Program {
        static void Main(string[] args) {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt"));
            int[] report = (Array.ConvertAll(input, s => Int32.Parse(s)));

            Console.WriteLine(SolvePart1(report));
            Console.WriteLine(SolvePart2(report));
        }

        private static int SolvePart1(int[] report) {
            int result = 0;

            for (int i = 1 ; i < report.Length; i++) {
                if (report[i] > report[i - 1]) {
                    result++;
                }
            }
            return result;
        }

        private static int SolvePart2(int[] report) {
            int result = 0;

            for (int i = 1; i < report.Length - 2; i++)
            {
                int currentOne = report[i - 1] + report[i] + report[i + 1];
                int nextOne = report[i] + report[i + 1] + report[i + 2];

                if (nextOne > currentOne)
                {
                    result++;
                }
            }

            return result;
        }
    }
}