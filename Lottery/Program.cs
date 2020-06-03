using Lottery.model;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            LotteryTicket ticket = new LotteryTicket();

            Boolean play = true;
            while (play)
            {
                Boolean correct = false;
                correct = takeGuess(ticket);
                if (correct == true)
                {
                    Console.WriteLine("Correct! Thank you for playing!");
                }
                else
                {
                    Console.WriteLine("Another guess? (y/n)");
                    string next = Console.ReadLine().ToLower();
                    if (next == "n")
                    {
                        play = false;
                        Console.WriteLine("Correct number would have been: " + ticket.lotteryNumber + "\nThank you for playing");
                    }
                }
            }
        }

        public static Boolean takeGuess(LotteryTicket ticket)
        {
            Console.WriteLine("Please guess a 6-figure number:");
            string guess = Console.ReadLine();
            string correctGuess = "";
            Boolean correct = true;
            for (int i = 0; i < ticket.lotteryNumber.Length; i++)
            {
                char charG = guess[i];
                char charT = ticket.lotteryNumber[i];
                if (charG == charT)
                {
                    correctGuess = correctGuess + charG;
                }
                else
                {
                    correctGuess = correctGuess + "*";
                    correct = false;
                }
            }
            if (correct == true)
            {
                return true;
            } 
            else
            {
                Console.WriteLine("Your correct numbers\n" + correctGuess);
                return false;

            }

            
        }
    }
}
