using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP04
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  IMAX 3D: {(Is3D ? "Yes" : "No")}");
        }
    }
}
