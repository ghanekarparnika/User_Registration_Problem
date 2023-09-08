// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Day11_Assig3;
using System;
//1) Write a program in C# Sharp to count a total number of duplicate elements in an array.

Console.WriteLine("Q1-print count of duplicate elements");

int[] arr = { 1, 2, 3, 4, 2, 5, 6, 4, 7, 8, 9, 1,2 };

int count = DuplicateElements.checkDouble_Elememts(arr);
Console.WriteLine("Total number of duplicate elements: " + count);
Console.WriteLine("===================================================");

//2) Write a program in C# Sharp to print all unique elements in an array.
Console.WriteLine("Q2-print count of Unique elements");
UniqueElements.printUnique();
Console.WriteLine();
Console.WriteLine("===================================================");
//3) Write a program in C# Sharp to count the frequency of each element of an array.
Console.WriteLine("Q3-print Frequency of each element");
Frequency.calFrequency();
Console.WriteLine("===================================================");
//4) Write a program in C# Sharp to find maximum and minimum element in an array.
Console.WriteLine("Q4-print Max and Min element in array");
Max_Min_Element.printMax_Min();
Console.WriteLine("===================================================");
/*Write a program to print below pattern.
********
*******
******
*****
****
***
**
*           */
Console.WriteLine("Q5-print given pattern");
Pattern.pattern1();
Console.WriteLine("===================================================");
/*6) Write a program to print below pattern.
* * * * * * *

*          *

*           *

*           *

*           *

*           *

* * * * * * *
 
 
 */
Console.WriteLine("Q6-print given pattern");
Pattern.pattern2();
Console.WriteLine("=====================================================");
//7) How to Reverse Each Word in a Given String in C#. 
Console.WriteLine("Q7-reverse String");
string input = "Hello, World!";
string reversed = ReverseString.reverseString(input);

Console.WriteLine("Original String: " + input);
Console.WriteLine("Reversed String: " + reversed);
Console.WriteLine("=====================================================");

//8) C# program to find sum of all digits of a given number.
Console.WriteLine("Q8-sum of all dogits in given number");
Sum.add();
Console.WriteLine("=====================================================");
