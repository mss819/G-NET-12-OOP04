using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP04
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public double Price { get; set; }

        public double PriceAfterTax
        {
            get { return Price * 1.14; }
        }

        // Virtual method
        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} | After Tax: {PriceAfterTax}");
        }

        // Overloading
        public void SetPrice(double price)
        {
            Console.WriteLine($"Setting price directly: {price}");
            Price = price;
        }

        public void SetPrice(double basePrice, double multiplier)
        {
            Price = basePrice * multiplier;
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {Price}");
        }
    }
}
