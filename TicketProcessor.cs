using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP04
{
    public static class TicketProcessor
    {
        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n========== Process Single Ticket ==========");
            t.PrintTicket();
        }
    }
}
