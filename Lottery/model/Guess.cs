using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Lottery.model
{
    class Guess
    {
        /// <summary>
        /// contains 6 numbers
        /// </summary>
        public String guessString { get; set; }

        public Guess()
        {
            Boolean correctTip = false;
            while (correctTip == false)
            {
                Console.WriteLine("Enter your 6-digit tip:");
                string tip = Console.ReadLine();
                correctTip = true;
                if (tip.Length != 6)
                {
                    Console.WriteLine("doesn't have 6 digits...");
                    correctTip = false;
                } 
                else
                {
                    this.guessString = tip;
                }
            }
        }
    }
}
