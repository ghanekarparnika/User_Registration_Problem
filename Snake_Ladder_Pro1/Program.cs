// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//UC7-Play the game with 2 Player.In this case if a Player gets a Ladder then plays again.Finally report which Player won the game
using System.Numerics;

internal class Programm
{
    const int NO_PLAY= 1;
    const int LADDER= 2;
    const int SNAKE= 3;


    public static void Main(String[] args)
    {

        Console.WriteLine("welcome to Snake Ladder Game...lets start");
        int player1Position = 0;
        int player2Position = 0;
        int count = 0;
        int currentPlayer = 1; 

        while (player1Position < 100 && player2Position<100) 
        { 
         //simulate rolling a die (1 to 6)
             Random random = new Random();
                   int diceValue = random.Next(1, 7);
            count++;
                
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
                    if(currentPlayer==1)
                    {
                        player1Position += diceValue;
                    }
                    else
                    {
                        player2Position += diceValue;
                    }
           
                break;
            case SNAKE:
                Console.WriteLine("oooops....Snake");
                    if (currentPlayer == 1)
                    {
                        player1Position -= diceValue;
                    }
                    else
                    {
                        player2Position -= diceValue;
                    }
                    break;


            }

            //ensure the players position is not below zero
            if (player1Position<0) 
            {
                Console.WriteLine("oops...player1 you are at zero....restarting game");
                player1Position = 0;
            }

            if (player2Position < 0)
            {
                Console.WriteLine("oops...player2 you are at zero....restarting game");
                player2Position = 0;
            }


            //ensure the players position is exact 100.
            if (player1Position >100)
            {
                player1Position -= diceValue;
            }
            if (player2Position >100) 
            { 
                player2Position-= diceValue;
            }

            //report players psition after every roll
            Console.WriteLine("player1 at position: "+player1Position);
            Console.WriteLine("player2 at position: " + player2Position);

            // Check for a ladder and switch to the other player if needed
            if (option == 1)
            {
                if (currentPlayer == 1)
                    currentPlayer = 2;
                else
                    currentPlayer = 1;
            }
        }
        if (player1Position >= 100)
            Console.WriteLine("Player 1 won the game!");
        else
            Console.WriteLine("Player 2 won the game!");

        Console.WriteLine($"Total dice rolls: "+count);
    }
}