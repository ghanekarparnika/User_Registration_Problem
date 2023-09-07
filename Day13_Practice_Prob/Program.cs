// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*UC1-Given 3 Integers find the maximum

- Ensure to test code with the Test Case.
- To ensure your Code works you need 3
test cases with Max Number at 1st, 2nd
and 3rd
- Use Integer Object and compareTo
UC 1 method to test the maximum number*/

using Day13_Practice_Prob;

//TC 1.1-Given Max Number at 1st Position return the Same Number Ensure the test data has Max Number in the First position
int result = TestMaximum.maxInteger(200, 56, 1);
Console.WriteLine("max Integer is : " + result);
//TC 1.2-Given Max Number at 2nd Position return the Same Number Ensure the test data has Max Number in the Second position
int result1 = TestMaximum.maxInteger(56, 200, 1);
Console.WriteLine("max Integer is : " + result1);

//TC 1.3Given Max Number at 3rd Position return the Same Number Ensure the test data has Max Number in the Third position
int result3 = TestMaximum.maxInteger(56, 45, 100);
Console.WriteLine("max Integer is : " + result3);

Console.WriteLine("=================================================================");
/*Given 3 Floats find themaximum

- Ensure to test code with the Test Case and*/

//TC 2.1-Given Max Number at 1st Position return the Same Number Ensure the test data has Max Number in the First position
float result4 = TestMaximum.maxFloat(20.3f, 10.3f, 7.9f);
Console.WriteLine("max Float is : " + result4);

//TC 2.2-Given Max Number at 2nd Position return the Same Number Ensure the test data has Max Number in the Second position
float result5 = TestMaximum.maxFloat(20.3f, 100.3f, 7.9f);
Console.WriteLine("max Float is : " + result5);
//TC 2.3Given Max Number at 3rd Position return the Same Number Ensure the test data has Max Number in the Third position
float result6 = TestMaximum.maxFloat(20.3f, 10.3f, 70.9f);
Console.WriteLine("max Float is : " + result6);