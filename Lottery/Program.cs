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
            TicketController ticketController = new TicketController();
            LotteryTicket ticket = new LotteryTicket();
            ticketController.playGame(ticket);
        }
    }
}
