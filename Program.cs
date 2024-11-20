using System;

namespace myfirstclr
{
    class Program
    {
        static void Main(string[] args)
        {
           string firstNameGivenByMyFather = "Adekunle";
            string lastName = "Rabiu";
            string fullName = firstNameGivenByMyFather + " " + lastName;

            /////////////////////////// ////////  TYPE CASTING OR CONVERSION/////////////////////////////////////////
            string i = 6.ToString(); // This is explicit casting because value type have to be casted authomatically to string
            object j = i;  // This implicit casting becasue it cast authomatically (1.e does not required manual casting)
            Console.WriteLine(fullName, i);
            int k  = 5;
            long l = k; // This is implicit casting
            double n = 2.5;
            l = (long)n; // This is explicit casting 
            l = Convert.ToInt64(n); // This is the other was of doing explicit casting
            

            //TYPE OF CASTING 
             //implicit conversion;
             //explicit conversion;
            //conversion to or from string;

            // Implicit Type Conversion – Examples
            int myInt = 5;
            Console.WriteLine(myInt); // 5
            long myLong = myInt;
            Console.WriteLine(myLong); // 5
            Console.WriteLine(myLong + myInt); // 10


            // Explicit Type Conversion – Example
            double myDouble = 5.1d;
            Console.WriteLine(myDouble); // 5.1
            long myLong1 = (long)myDouble;
            Console.WriteLine(myLong1); // 5
            myDouble = 5e9d; // 5 * 10^9
            Console.WriteLine(myDouble); // 5000000000
            int myInt1 = (int)myDouble;
            Console.WriteLine(myInt1); // -2147483648
            Console.WriteLine(int.MinValue); // -2147483648
            long myLong2 = long.MaxValue;
            int myInt2 = (int)myLong2;
            Console.WriteLine(myLong2); // 9223372036854775807
            Console.WriteLine(myInt2); // -1

            float heightInMeters = 1.74f; // Explicit conversion
            double maxHeight = heightInMeters; // Implicit
            double minHeight = (double)heightInMeters; // Explicit
            float actualHeight = (float)maxHeight; // Explicit
            //float maxHeightFloat = maxHeight; // Compilation error!

            int a = 5;
            int b = 7;
            string sum = "Sum = " + (a + b);
            Console.WriteLine(sum);
            String incorrect = "Sum = " + a + b;
            Console.WriteLine(incorrect);
            Console.WriteLine(
            "Perimeter = " + 2 * (a + b) + ". Area = " + (a * b) + ".");



            // EXPRESSION
            int r = (150-20) / 2 + 5;
            // Expression for calculating the surface of the circle
            double surface = Math.PI * r * r; // Pi r^2
            // Expression for calculating the perimeter of the circle
            double perimeter = 2 * Math.PI * r; // 2 Pi r
            Console.WriteLine("Radius = " + r);
            Console.WriteLine("Area of a circle = " + surface);
            Console.WriteLine("Perimeter Of a circle = " + perimeter);

            int a1 = 5;
            int b1 = ++a1;
            Console.WriteLine(a1); // 6
            Console.WriteLine(b1); // 6

            int num = 1;
            double denum = 0; // The value is 0.0 (real number)
            int zeroInt = (int) denum; // The value is 0 (integer number)
            Console.WriteLine(num / denum); // Infinity
            Console.WriteLine(denum / denum); // NaN
            Console.WriteLine(zeroInt / zeroInt); // DivideByZeroException

            double incorrect1 = (double)((1 + 2) / 4);
            Console.WriteLine(incorrect1); // 0

            double correct = ((double)(1 + 2)) / 4;
            Console.WriteLine(correct); // 0.75
            Console.WriteLine("2 + 3 = " + 2 + 3); // 2 + 3 = 23
            Console.WriteLine("2 + 3 = " + (2 + 3)); // 2 + 3 = 5


            Console.WriteLine("Hello World!");
        }
    }
}
