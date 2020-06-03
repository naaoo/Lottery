using Lottery.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery.controller
{
    class LotteryController
    {
        /// <summary>
        /// contains all guesses as 6-figure strings
        /// </summary>
        public List<Guess> guessList = new List<Guess>();

        public void playGame(LotteryTicket ticket)
        {
            Boolean play = true;
            while (play)
            {
                getGuesses();
                int correctValues = checkCorrect(ticket);
                if (correctValues == 6)
                {
                    Console.WriteLine("You guessed correct! Winning number: " + ticket.lotteryNumber);
                    play = false;
                } 
                else
                {
                    Console.WriteLine("Highest numbers correct (in a guess): " + correctValues + "\nKeep adding guesses? (y/n)");
                    string cont = Console.ReadLine();
                    if (cont == "n")
                    {
                        Console.WriteLine("Correct number: " + ticket.lotteryNumber);
                        play = false;
                    }
                }
            }
        }

        private void getGuesses()
        {
            Boolean newGuess = true;
            while (newGuess)
            {
                guessList.Add(new Guess());
                Console.WriteLine("Add another guess? (y/n)");
                string another = Console.ReadLine().ToLower();
                if (another == "n")
                {
                    newGuess = false;
                }
            }
        }

        private int checkCorrect(LotteryTicket ticket)
        {
            int correctValues = 0;
            foreach (Guess guess in guessList)
            {
                int correctValuesGuess = 0;
                for (int i = 0; i < guess.guessString.Length; i++)
                {
                    char charG = guess.guessString[i];
                    char charT = ticket.lotteryNumber[i];
                    if (charG == charT)
                    {
                        correctValuesGuess++;
                    }

                }
                if (correctValuesGuess > correctValues)
                {
                    correctValues = correctValuesGuess;
                }
            }
            return correctValues;
        }
    }
}
