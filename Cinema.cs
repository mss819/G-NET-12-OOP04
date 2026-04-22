using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP04
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public void Open()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            Console.WriteLine("Projector started.");
        }

        public void Close()
        {
            Console.WriteLine("\n========== Cinema Closed ==========");
            Console.WriteLine("Projector stopped.");
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n========== All Tickets ==========");
            foreach (var t in tickets)
            {
                if (t != null)
                    t.PrintTicket(); // polymorphism 🔥
            }
        }
    }
}
