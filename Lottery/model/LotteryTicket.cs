using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery.model
{
    class LotteryTicket
    {
        public string lotteryNumber { get; set; }

        public LotteryTicket()
        {
            string numberString = "";
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                int randomNumber = random.Next(0, 10);
                numberString = numberString + randomNumber.ToString();
            }
            this.lotteryNumber = numberString;
        }
    }
}
