// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//UC2-The player rolls the die to get a number between 1 to 6

internal class Programm
{
    const int NO_PLAY= 1;
    const int LADDER= 2;
    const int SNAKE= 3;

    public static void Main(String[] args) 
    {
        int position = 0;
        
        //simulate rolling a die (1 to 6)
        Random random = new Random();   
        int diceValue=random.Next(1,7);
        Console.WriteLine("welcome to Snake Ladder Game...lets start");
        //simulate option: NO_PLAY,LADDER,SNAKE
        Random random1 = new Random();
        int option=random1.Next(1,4);
        switch(option) 
        {
            case NO_PLAY:
                Console.WriteLine("no play");
                break; 
            case LADDER:
                Console.WriteLine("ladder");
                position +=diceValue ;
                Console.WriteLine("You are at position: "+position);
                break; 
            case SNAKE:
                Console.WriteLine("Snake");
                position -=diceValue ;
                Console.WriteLine("You are at position: " + position);
                break;


        }
    }
}