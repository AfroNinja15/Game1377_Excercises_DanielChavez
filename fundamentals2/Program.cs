namespace fundamentals2
{        
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Switch();
            ArrayLoops();
            int[] intArray = new int[5];
            float[] floatArray = new float[5];
            double[] doubleArray = new double[5];
            IntMethod(intArray);
            FloatMethod(floatArray);
            DoubleMethod(doubleArray);
            ConvertIntToFloatMethod(intArray);
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
            Console.WriteLine("For: " + sumAverage);

            //2e
            for (int i = 0;i < intArray.Length; i++)
            {
                if (i % 2  == 0)
                {
                    continue;
                }
                Console.WriteLine(intArray[i]);
            }

            //2f
            for (int i = 0; i < intArray.Length; i++)
            {
                if (i % 3 != 2)
                {
                    continue;
                }
                Console.WriteLine(intArray[i]);
            }

            //2g
            Console.WriteLine("ArraySize");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("rangeMin");
            int rangeMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("rangeMax");
            int rangeMax = Convert.ToInt32(Console.ReadLine());

            int[] intArray2 = new int[arraySize];
            for(int i = 0; i < arraySize; i++)
            {
                intArray2[i] = new Random().Next(rangeMin, rangeMax);
            }
        }
        //3a
        private static void IntMethod(int[] p1)
        {
            for (int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine(p1[i]);
            }
        }
        //3b float
        private static void FloatMethod(float[] p1)
        {
            for(int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine(p1[i]);
            }
        }
        //3b double
        private static void DoubleMethod(double[] p1)
        {
            for (int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine(p1[i]);
            }
        }
        //3c
        private static void ConvertIntToFloatMethod(int[] p1)
        {
            
        }
    }
}
