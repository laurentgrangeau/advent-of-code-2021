using System;

namespace aocday1 {
    class main {
        static void main(string[] args) {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puzzleInput.txt"));
            int[] report = (Array.ConvertAll(input, s => Int32.Parse(s)));

            Console.WriteLine();
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
    }
}