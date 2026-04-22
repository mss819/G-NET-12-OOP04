using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP04
{
    public class StandardTicket : Ticket
    {
        public char Row { get; set; }
        public int SeatNumber { get; set; }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  Seat: {Row}-{SeatNumber}");
        }
    }
}
