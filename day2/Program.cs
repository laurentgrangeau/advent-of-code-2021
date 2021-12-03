namespace aocday1 {
    class Program {
        static void Main(string[] args) {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt"));

            Console.WriteLine(SolvePart1(input));
            Console.WriteLine(SolvePart2(input));
        }

        private static int SolvePart1(string[] input) {
            int result = 0;
            int position = 0;
            int depth = 0;

            for (int i = 0; i < input.Length; i++) {
                string[] words = input[i].Split(' ');
                switch (words[0])
                {
                    case "forward":
                        position += int.Parse(words[1]);
                        break;
                    case "down":
                        depth += int.Parse(words[1]);
                        break;
                    case "up":
                        depth -= int.Parse(words[1]);
                        break;
                    default:
                        break;
                }
            }

            result = position * depth;

            return result;
        }

        private static int SolvePart2(string[] input) {
            int result = 0;
            int position = 0;
            int depth = 0;
            int aim = 0;

            for (int i = 0; i < input.Length; i++) {
                string[] words = input[i].Split(' ');
                switch (words[0])
                {
                    case "forward":
                        position += int.Parse(words[1]);
                        depth += aim * int.Parse(words[1]);
                        break;
                    case "down":
                        aim += int.Parse(words[1]);
                        break;
                    case "up":
                        aim -= int.Parse(words[1]);
                        break;
                    default:
                        break;
                }
            }

            result = position * depth;

            return result;
        }
    }
}