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
