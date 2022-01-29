using System;
using System.Collections.Generic;


public class Director
{
    public void Main()
    {   
        startGame();

        bool isplaying = true;
        int Distance = 0;
        int healthPoints = 100;

        if (Distance == 1000)
        {
            Console.WriteLine("Congratulations! You have won!");
            Console.WriteLine("Would you like to try again? y/n");
            string playAgain =  Console.ReadLine();
            if (playAgain == "y")
            {
                isplaying  = true;
            }
        }
        if (healthPoints == 0)
        {
            isplaying = false;
        }
        if (isplaying == false)
        {
            Console.WriteLine("Good try, but you died.");
        }
    }
    public void startGame()
    {
        Console.WriteLine("welcome to New Oregon Trail! Would you like to play the game? y/n: ");
         string userinput = Console.ReadLine();
         if (userinput == "y")
         {
            Console.WriteLine("Great! Let's start the game!");
            Console.WriteLine("Awesome, What is your adventurer's name? ");
            string name = Console.ReadLine();
            
         }
         
    }
}