using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace guessgame
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            string Difficulty = "";
            Console.WriteLine("Enter your difficulty level: Easy, Medium or Hard");
            Difficulty = Console.ReadLine();

            string [] difficultyEasy = new string[1]{"Easy"};
            string [] difficultyMedium = new string[1]{"Medium"};
            string [] difficultyHard = new string[1]{"Hard"};

            for (int x =0; x < difficultyEasy.Length; x++)
            for (int y =0; y < difficultyMedium.Length; y++)
            for (int z =0; z < difficultyHard.Length; z++)

                if(Difficulty == difficultyEasy[x])
                {   
                    Random random = new Random();
                    bool gameOver = false;
                    int guess;
                    int randomNumber = random.Next(1, 11);                      
                    int numberOfGuesses = 6;
                        
                    Console.WriteLine("I am thinking of a number between 1 and 10! What is it?");

                    while(gameOver == false)
                    {                   
                        guess = Convert.ToInt32(Console.ReadLine());
                        numberOfGuesses--;

                        if (guess != randomNumber && numberOfGuesses == 0)
                        {
                            Console.WriteLine("Game over!");
                            gameOver = true;
                        }
                        else if (guess == randomNumber)
                        {
                            Console.WriteLine("You got it right!");
                            gameOver = true;
                        }
                        else if (guess != randomNumber)
                            Console.WriteLine("That was wrong! You have " + numberOfGuesses + " guess(es) left" );                    
                    }
                    Console.ReadLine();
                    
                }

                else if (Difficulty == difficultyMedium[y])
                {   
                    Random random = new Random();
                    bool gameOver = false;
                    int guess;
                    int randomNumber = random.Next(1, 21);                       
                    int numberOfGuesses = 4;
                        
                    Console.WriteLine("I am thinking of a number between 1 and 20! What is it?");

                    while(gameOver == false)
                    {                   
                        guess = Convert.ToInt32(Console.ReadLine());
                        numberOfGuesses--;

                        if (guess != randomNumber && numberOfGuesses == 0)
                        {
                            Console.WriteLine("Game over!");
                            gameOver = true;
                        }
                        else if (guess == randomNumber)
                        {
                            Console.WriteLine("You got it right!");
                            gameOver = true;
                        }
                        else if (guess != randomNumber)
                            Console.WriteLine("That was wrong! You have " + numberOfGuesses + " guess(es) left" ); 
                                     
                    }
                    Console.ReadLine();
                    
                }

                else if (Difficulty == difficultyHard[z])
                {   
                    Random random = new Random();
                    bool gameOver = false;
                    int guess;
                    int randomNumber = random.Next(1, 51);                       
                    int numberOfGuesses = 3;
                        
                    Console.WriteLine("I am thinking of a number between 1 and 50! What is it?");

                    while(gameOver == false)
                    {                   
                        guess = Convert.ToInt32(Console.ReadLine());
                        numberOfGuesses--;

                        if (guess != randomNumber && numberOfGuesses == 0)
                        {
                            Console.WriteLine("Game over!");
                            gameOver = true;
                        }
                        else if (guess == randomNumber)
                        {
                            Console.WriteLine("You got it right!");
                            gameOver = true;
                        }
                        else if (guess != randomNumber)
                            Console.WriteLine("That was wrong! You have " + numberOfGuesses + " guess(es) left" );                    
                    }
                    Console.ReadLine();

                }

                else if (Difficulty != difficultyEasy[x] || Difficulty != difficultyMedium[y] || Difficulty != difficultyHard[z])
                    Console.WriteLine("Invalid selection");
                    Console.ReadLine();
        }
    }                   
}
