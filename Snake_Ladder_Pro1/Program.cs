// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//UC4-Repeat till the Player reaches the winning position 100. 

internal class Programm
{
    const int NO_PLAY= 1;
    const int LADDER= 2;
    const int SNAKE= 3;


    public static void Main(String[] args)
    {

        Console.WriteLine("welcome to Snake Ladder Game...lets start");
        int position = 0;

        while (position < 100) 
        { 
         //simulate rolling a die (1 to 6)
             Random random = new Random();
                   int diceValue = random.Next(1, 7);
                
        //simulate option: NO_PLAY,LADDER,SNAKE
                  Random random1 = new Random();
                 int option = random1.Next(1, 4);
            switch (option)
                {
            case NO_PLAY:
                Console.WriteLine("no play");
                break;
            case LADDER:
                Console.WriteLine("yey!...ladder");
                position += diceValue;
               // Console.WriteLine("You are at position: " + position);
                break;
            case SNAKE:
                Console.WriteLine("oooops....Snake");
                position -= diceValue;
               // Console.WriteLine("You are at position: " + position);
                break;


            }
            //ensure the players position is not below zero
            if (position<0) 
            {
                Console.WriteLine("oops...you are at zero....restarting game");
                position = 0;
            }
           

            //report players psition after every roll
            Console.WriteLine("you are at: "+position);
        }
    }
}