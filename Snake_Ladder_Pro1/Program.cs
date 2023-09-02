// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//UC2-The player rolls the die to get a number between 1 to 6

internal class Programm
{
    public static void Main(String[] args) 
    {
        int position = 0;
        
        Random random = new Random();   
        int diceValue=random.Next(1,7);
        Console.WriteLine("welcome to Snake Ladder Game...lets start");
        Console.WriteLine("You have got dicevalue: "+diceValue);
    }
}