using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP04
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public double ServiceFee { get; set; }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee}");
        }
    }
}
