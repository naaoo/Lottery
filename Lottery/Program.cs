using Lottery.controller;
using Lottery.model;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two versions:
            // 1) Number guessing-game:
            /*
            TicketController ticketController = new TicketController();
            LotteryTicket ticket = new LotteryTicket();
            ticketController.playGame(ticket);
            */
            // 2) More lottery-like:
            LotteryController lotteryController = new LotteryController();
            LotteryTicket ticket = new LotteryTicket();
            lotteryController.playGame(ticket);
        }
    }
}
