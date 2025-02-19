﻿using System.Reflection;

namespace fundamentals2
{        
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Switch();
            ArrayLoops();

            //Methods
            Console.WriteLine("ArraySize");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("rangeMin");
            int rangeMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("rangeMax");
            int rangeMax = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[5];
            float[] floatArray = new float[5];
            Console.WriteLine("Float is " + FloatDoubleMethod(floatArray));
            Console.WriteLine("Average is " + AverageOverloadMethod(floatArray));
            double[] doubleArray = new double[5];
            Console.WriteLine("Double is " + FloatDoubleMethod(doubleArray));
            Console.WriteLine("Average is " + AverageOverloadMethod(doubleArray));
            IntMethod(intArray);
            ConvertIntToFloatMethod(intArray);
            DynamicSizedMethod(arraySize, rangeMin, rangeMax);
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
            sumAverage = (sum / intArray.Length);
            Console.WriteLine("For: " + sumAverage);

            //2e
            for (int i = 0; i < intArray.Length; i++)
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
        //3b
        private static float FloatDoubleMethod(float[] p1)
        {
            for(int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine(p1[i]);
            }
            return p1[0];
        }
        private static double FloatDoubleMethod(double[] p1)
        {
            for (int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine(p1[i]);
            }
            return p1[0];
        }
        //3c
        private static float ConvertIntToFloatMethod(int[] p1)
        {
            float[] floatArray = new float[p1.Length];
            float sumAverage = 0;
            for (int i = 0; i < p1.Length; i++)
            {
                floatArray[i] = p1[i];
                sumAverage += floatArray[i];
            }
            sumAverage = (sumAverage / p1.Length);
            Console.WriteLine(" Float For: " + sumAverage);
            return sumAverage;

        }
        //3d
        private static float AverageOverloadMethod(float[] p1)
        {
            {
                float sumAverage;
                float sum = 0;
                for (int i = 0; i < p1.Length; i++)
                {
                    sum += p1[i];
                }
                sumAverage = (sum / p1.Length);
                Console.WriteLine("Float For: " + sumAverage);
                return sumAverage;
            }
        }
        private static double AverageOverloadMethod(double[] p2)
        {
            {
                double sumAverage2;
                double sum2 = 0;
                for (int i = 0; i < p2.Length; i++)
                {
                    sum2 += p2[i];
                }
                sumAverage2 = (sum2 / p2.Length);
                Console.WriteLine(" Double For: " + sumAverage2);
                return sumAverage2;
            }
        }
        //3e
        private static void DynamicSizedMethod(int p1, int p2, int p3)
        {
            int[] intArray2 = new int[p1];
            for (int i = 0; i < p1; i++)
            {
                intArray2[i] = new Random().Next(p2, p3);
            }
        }
    }
}
