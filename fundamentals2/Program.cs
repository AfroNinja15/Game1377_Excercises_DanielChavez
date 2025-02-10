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
            //1a
            Console.WriteLine("Input a WASD key then press ENTER");
            string? userInput;
            userInput = Console.ReadLine();
            //1b
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
            //2a
            int[] intArray = {-783, 47, 50, 94, 100, 107, 132, 135, 159, 179};

            //2b
            for (int i = intArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine("For: " + intArray[i]);
            }

            //2c
            bool userInputBool = true;

            while (userInputBool)
            {
                Console.WriteLine("Input any number");
                string? userInput;
                userInput = Console.ReadLine();
                int intInput;
                int.TryParse(userInput, out intInput);

                if (userInput != null)
                {
                    foreach (int i in intArray)
                    {
                        if (intInput == i)
                        {
                            Console.WriteLine("Hey you typed a lucky number");
                            userInputBool = false;
                        }
                    }
                }
                if (userInputBool == true)
                {
                    Console.WriteLine("Keep trying");
                }
            }

            //2d
            int sumAverage;
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            sumAverage = (sum / 10);
            Console.WriteLine(sumAverage);
        }
        private static void Methods()
        {

        }
    }
}
