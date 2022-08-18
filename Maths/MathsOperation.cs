using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    class MathsOperation
    {
        public int Sum(int firstNumber, int secondNumber)

        {
            int result = firstNumber + secondNumber;
            return result;
        }

        public int[] GetArray()
        {
            int[] array1 = new int[5];

            array1[0] = 10;
            array1[1] = 20;
            array1[3] = 30;
            array1[3] = 40;

            return array1;


        }

        public int ResultSum(int firstnumber, int secondnumber)
        {
            int result = firstnumber + secondnumber;
            return result;

        }
        public int Subtract(int firstnumber, int secondnumber)
        {
            int result = firstnumber - secondnumber;
            return result;
        }

        public int Multiply(int firstnumber, int secondnumber)
        {
            int result = firstnumber * secondnumber;
            return result;

        }

        public int Divide(int firstnumber, int secondnumber)
        {
            int result = firstnumber / secondnumber;
            return result;

        }


        public int Getresultvalue()
        {
            int resultValue = 100;
            return resultValue;

        }


        public string GetResultString()
        {
            string Name = "Charu";
            return Name;
        }









    }
}
