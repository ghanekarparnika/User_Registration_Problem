using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAProblem
{
    internal class StringPermutations
    {
        HashSet<string> set =new HashSet<string>();
        public void permutation()
        {
            Console.WriteLine("Enter the string: ");
            string str= Console.ReadLine();
            string result = "";
            permute(str, result);
            Console.WriteLine("\n permutaion of the string are: \n"+str);
            foreach(string s in set)
            {
                Console.WriteLine(s);
            }
        }
        public void permute(string str, string result) 
        {
            if(str.Length ==0)
            {
                set.Add(result);
                return;
            }
            for(int i = 0;i < str.Length; i++) 
            {
                char ch = str[i];
                string left_substring=str.Substring(0,i);
                string right_substring=str.Substring(i+1);
                string rest=left_substring+right_substring;
                permute(rest, result + ch);
            }
        }
    }
}
