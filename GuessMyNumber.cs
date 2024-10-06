using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NumbersGame
{
    internal class GuessMyNumber
    {
        public void generateNumbers()
        {
            // Create an instance of the ramdom class to generate random numbers
            Random random = new Random();
            //Generating a secret random number between 1-20.
            int secretNumber = random.Next(1, 21);
            // Variable store user´s guessed number.
            int givenNumber;


            Console.WriteLine("Välkommen jag tänker på ett nummer. Kan du gissa vilket? du får 5 försök.");

            /*A boolean to check if the user guessed the correct number
            set to false so user entered number is set to true in the condítion later in the code */

            bool guessedCorrectly = false;

            // Loop for 5 attempts
            for (int attempts = 0; attempts < 5; attempts++)
            {
                // Control for valid integer
                if (int.TryParse(Console.ReadLine(), out givenNumber))
                {
                    // A metod for checking if guessed number is correct, to low or too high
                    CheckGuess(givenNumber, secretNumber);

                    // if the guess matches the sercret number guessedCorrectly will be set to true and end the loop.
                    if (givenNumber == secretNumber)
                    {
                        guessedCorrectly = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Mata in rätt format");
                }


            }
            /* After loop av 5 attempts , 
             * if the user guessed incorrectly this leads to guessedCorrectly NOT true
             * and will initiate the condition */

            if (!guessedCorrectly)
            {
                Console.WriteLine("Tyvärr så lyckades du inte på 5 försök");
            }


        }
        // A method created to check the user´s guess number against the secret number.
        public static void CheckGuess(int guessedNumber, int secretNumber)
        {

            
            if (guessedNumber < secretNumber)
            {
                Console.WriteLine("Tyvärr, du gissade fär lågt");

            }
            else if (guessedNumber > secretNumber)
            {
                Console.WriteLine("Tyvärr,du gissade för högt");
            }
            else if (guessedNumber == secretNumber)
            {
                Console.WriteLine("Grattis du gissade rätt");
            }

        }
    }
}
