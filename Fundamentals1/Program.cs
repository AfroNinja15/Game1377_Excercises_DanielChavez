namespace Fundamentals1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            OutputStrings();
            Arithmetic();
            Assignment();
            ComparisonAndConditionals();
        }
        private static void OutputStrings()
        {
            string sentence1 = "I'm in Game 1377: Scripting for Game Designers";
            Console.WriteLine(sentence1);                   //Outputting string
            Console.WriteLine(sentence1.ToUpper());         // All Caps
            Console.WriteLine(sentence1.ToLower());         // All lower case
            Console.WriteLine(sentence1.Substring(7));      // Starting from 8 starting from 0 - 7
            Console.WriteLine(sentence1.Substring(7, 10));   // only 8-11
            Console.WriteLine(sentence1[7]);                // just 8
        }
        private static void Arithmetic()
        {
            int intInput1 = 2, intInput2 = 4;           // Declaring
            int sum = intInput1 + intInput2;          // Addition
            Console.WriteLine(sum);
            int difference = intInput1 - intInput2;   // Subtraction
            Console.WriteLine(difference);
            int product = intInput1 * intInput2;      // Multiplication
            Console.WriteLine(product);
            float quotient = (float) intInput1 / intInput2;     // Division
            Console.WriteLine(quotient);
            int remainder = intInput1 % intInput2;    // Percentile
            Console.WriteLine(remainder);
        }
        private static void Assignment()
        {
            float floatInput1 = 3.3f;
            float floatInput2 = 4.4f;

            floatInput2 = (floatInput2 + floatInput1);
            Console.WriteLine(floatInput2);
            floatInput2 = (floatInput2 - floatInput1);
            Console.WriteLine(floatInput2);
            floatInput2 = (floatInput1 * floatInput2);
            Console.WriteLine(floatInput2);
            floatInput2 = (floatInput2 / floatInput1);
            Console.WriteLine(floatInput2);

        }
        private static void ComparisonAndConditionals()
        {
            int intInput1 = 2, intInput2 = 5;

            if (intInput1 == intInput2)
            {
                Console.WriteLine("intInput1 is equal to intInput2");
            }
            else if (intInput1 != intInput2)
            {
                Console.WriteLine("intInput1 does not equal intInput2");
            }
            else if (intInput1 > intInput2)
            {
                Console.WriteLine("intInput1 is greater than intInput2");
            }
            else if (intInput1 < intInput2)
            {
                Console.WriteLine("intInput2 is greater than intInput1");
            }
            else
            {
                Console.WriteLine("Neither input compare to eachother");
            }
        }
    }

}
