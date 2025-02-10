namespace fundamentals2
{        
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Switch();
            ArrayLoops();
            Methods();
        }
        private static void Switch()
        {
            Console.WriteLine("Input a WASD key tehn press ENTER");
            string? userInput;
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "W":
                    Console.WriteLine("You moved up");
                    break;
                case "S":
                    Console.WriteLine("You moved down");
                    break;
                case "A":
                    Console.WriteLine("You moved left");
                    break;
                case "D":
                    Console.WriteLine("You moved right");
                    break;
                default:
                    Console.WriteLine("Please input W, A, S, or D.");
                    break;
            }
        }
        private static void ArrayLoops()
        {
            int[] intArray = {-783, 47, 50, 94, 100, 107, 132, 135, 159, 179};

            for (int i = 9; i < intArray.Length; i--)
            {
                Console.WriteLine(intArray[i]);
            }

        }
        private static void Methods()
        {

        }
    }
}
