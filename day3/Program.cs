namespace aocday3 {
    class Program {
        static void Main(string[] args) {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt"));

            Console.WriteLine(SolvePart1(input));
            Console.WriteLine(SolvePart2(input));
        }

        private static int SolvePart1(string[] input) {
            int result = 0;
            string gamma = 0;
            string epsilon = 0;
            int[] bits = new int[input.Length];

            for (int i = 0; i < input.Length; i++) {
                foreach (char chars in input[i]) {
                    if (chars == '0') {
                        bits[i] -= 1;
                    } else if (chars == '1') {
                        bits[i] += 1;
                    }
                }
            }

            for (int k = 0; k < bits.Length; k++) {
                if (bits[k] > 0) {
                    gamma.Append('1');
                    epsilon.Append('0');
                } else if (bits[k] < 0) {
                    gamma.Append('0');
                    epsilon.Append('1');
                }
            }

            result = gamma * epsilon;

            return result;
        }

        private static int SolvePart2(string[] input) {
            int result = 0;
            return result;
        }
    }
}