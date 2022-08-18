using System;

namespace Practice
{
    class MathsOperation
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter your First Number");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter your Second Number");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int sum = a + b;
            //    Console.WriteLine(sum);

            //int a = 20;
            //float b = a;
            //Console.WriteLine(b);
            //Console.ReadLine();


            //Console.WriteLine("Enter your First Number");
            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter your Second Number");
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter your Third Number");
            //int z = Convert.ToInt32(Console.ReadLine());

            //int result1 = (x + y) * z;
            //int result2 = (x * y) + (y * z);

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);


            //Console.WriteLine("Input the marks obtained in Physics");
            //int P = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Input the marks obtained in Maths");
            //int M = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Input the marks obtained in Chemistry");
            //int C = Convert.ToInt32(Console.ReadLine());

            //int sum = P + C + M;
            //Console.WriteLine(sum);

            //if (P >= 55 && M >= 65 && C >= 60 && sum >= 280)

            //{  Console.WriteLine("You are eligible"); }

            //else

            //{ Console.WriteLine("You are not eligible"); }


            MathsOperations ObjMathsOp = new MathsOperations();
            int resultSum = ObjMathsOp.Sum(50, 100);

            int resultSubtract = ObjMathsOp.Subtract(50, 100);

            int resultMultiply = ObjMathsOp.Multiply(50, 100);

            int resultDivide = ObjMathsOp.Divide(50, 100);

            Console.WriteLine("Sum of the two number is" + resultSum);

            Console.WriteLine("Sum of the two number is" + resultSubtract);

            Console.WriteLine("Sum of the two number is" + resultMultiply);

            Console.WriteLine("Sum of the two number is" + resultDivide);




































            //Console.ReadLine();





















        }
    }
}
