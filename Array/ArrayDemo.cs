using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayDemo
    {
        public static void ArrayDeclaration()
        {
            int[] NumArray = new int[10];
            NumArray[0] = 1;
            NumArray[1] = 2;
            NumArray[2] = 3;
            NumArray[4] = 4;
            int[] NumArray2 = new int[7] { 10, 11, 12, 13, 14, 15, 16 };
            int[] NumArray3 = { 11, 13, 14, 15, 16 };

            Console.WriteLine(NumArray[3]);
            Console.WriteLine(NumArray.Length);
            for(int i = 0;i< NumArray.Length; i++) 
            {
                Console.WriteLine(NumArray[i]);
            }
            Console.WriteLine("========================================================");
            foreach(int i in NumArray) 
            { 
                Console.WriteLine(i);
            }

        }

        public static void ArrayListDeclaration() 
        {
            Console.WriteLine("Creating ArrayList...");
            ArrayList list= new ArrayList();
            list.Add(1);
            list.Add("PARNIKA");
            list.Add('P');
            list.Add(3.4f);
            Console.WriteLine("=================================================");
            Console.WriteLine("Reading ArrayList elements...");
            foreach(var data in list) 
            {
                Console.WriteLine(data);
            }

           // Console.WriteLine(list.Count);

            Console.WriteLine("=================================================");

           
            //object initializer
           /* var list3 = new ArrayList()
            { 1,"Parni",5.6f,'p',null};

            foreach (var data in list3)
            {
                Console.WriteLine(data);
            }*/
           Console.WriteLine("Updating element in Arraylist");
            list[2] = "GHANEKAR";
            foreach (var data in list)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("=================================================");
            Console.WriteLine("Updating element in Arraylist using insert method");
            list.Insert(3, "Developer");
            foreach (var data in list)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("=================================================");
            Console.WriteLine("Deleting element at perticular index from arraylist");
            list.RemoveAt(3);
            foreach (var data in list)
            {
                Console.WriteLine(data);
            }

            /*//we can give array directly to arraylist
            var list2 = new ArrayList();
            int[] arr = {10,11,12,13,14,15,16};
            list2.AddRange(arr);
            foreach (var data in list2)
            {
                Console.WriteLine(data);
            }*/



        }
    }
}
