using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Practice_Prob
{
    internal class GenericDemo2<T> where T : IComparable<T>
    {

        /* public T num1, num2, num3;
        public GenericDemo2(T num1,T num2,T num3) 
         {
             this.num1 = num1;
             this.num2 = num2;
             this.num3 = num3;
         }

         public T maxGen()
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
         }*/
        ///////////////////////////////////////////////////////////////////////////////////////////////////


        private List<T> values;
        public GenericDemo2(params T[] values)
        {
            if (values.Length == 0)
            {
                throw new ArgumentException("You must provide at least one value.");
            }

            this.values = values.ToList();
        }

        public T FindMaximum()
        {
            /* if (values.Count == 0)
             {
                 throw new InvalidOperationException("No values provided.");
             }

             values.Sort();
             return values.Last();*/
            if (values.Count == 0)
            {
                throw new InvalidOperationException("No values provided.");
            }

            values.Sort();
            T max = values.Last();
            PrintMax(max);
            return max;
        }
        private void PrintMax(T max)
        {
            Console.WriteLine("Maximum value : "+max);
        }
    }
}
