using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Practice_Prob
{
    internal class TestMaximum
    {
        public static int maxInteger(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num2.CompareTo(num3) > 0 ||
                num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 ||
                num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 ||
                num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 ||
                num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 ||
                num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 ||
                num2.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }

            throw new Exception("num1,num2,num3 are same");

        }

        public static float maxFloat(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num2.CompareTo(num3) > 0 ||
                num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 ||
                num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 ||
                num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 ||
                num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 ||
                num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 ||
                num2.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }

            throw new Exception("num1,num2,num3 are same");

        }

        public static string maxString(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) > 0 && str2.CompareTo(str2) > 0 ||
                str1.CompareTo(str2) >= 0 && str1.CompareTo(str3) > 0 ||
                str1.CompareTo(str2) > 0 && str1.CompareTo(str3) >= 0)
            {
                return str1;
            }
            if (str2.CompareTo(str1) > 0 && str2.CompareTo(str3) > 0 ||
                str2.CompareTo(str1) >= 0 && str2.CompareTo(str3) > 0 ||
                str2.CompareTo(str1) > 0 && str2.CompareTo(str3) >= 0)
            {
                return str2;
            }
            if (str3.CompareTo(str1) > 0 && str3.CompareTo(str2) > 0 ||
                str3.CompareTo(str1) >= 0 && str3.CompareTo(str2) > 0 ||
                str2.CompareTo(str1) > 0 && str3.CompareTo(str2) >= 0)
            {
                return str3;
            }

            throw new Exception("str1,str2,str3 are same");
        }



    }
}
