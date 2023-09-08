// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Day11_Assig3;
//1) Write a program in C# Sharp to count a total number of duplicate elements in an array.

Console.WriteLine("Q1-print count of duplicate elements");

int[] arr = { 1, 2, 3, 4, 2, 5, 6, 4, 7, 8, 9, 1,2 };

int count = DuplicateElements.checkDouble_Elememts(arr);
Console.WriteLine("Total number of duplicate elements: " + count);
Console.WriteLine("===================================================");
    