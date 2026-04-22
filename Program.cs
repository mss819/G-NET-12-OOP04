namespace G_NET_12_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //            Static Binding
            //بيحصل وقت الـ Compile
            //زي: Method Overloading
            //أسرع
            //Dynamic Binding
            //بيحصل وقت الـ Runtime
            //زي: Method Overriding
            //بيعتمد على نوع الـ object الحقيقي

            #endregion

            #region Question 2

            //Overloading
            /*نفس الاسم بس parameters مختلفة
             * في نفس الكلاس
             * Compile time
             */
            //Overriding
            /*
             * نفس الاسم ونفس التوقيع
             * في inheritance
             * Runtime
             */

            #endregion

            #region Question 3

            //virtual => تسمح للـ method إنها تتعمل override
            //override => إعادة تعريف الميثود
            //base => تنادي على الميثود الأصلية

            #endregion

            #region Question 4
            Cinema cinema = new Cinema();
            cinema.Open();

            // Create tickets
            StandardTicket t1 = new StandardTicket
            {
                TicketId = 1,
                MovieName = "Inception",
                Row = 'A',
                SeatNumber = 5
            };

            VIPTicket t2 = new VIPTicket
            {
                TicketId = 2,
                MovieName = "Avengers",
                LoungeAccess = true,
                ServiceFee = 50
            };

            IMAXTicket t3 = new IMAXTicket
            {
                TicketId = 3,
                MovieName = "Dune",
                Is3D = false
            };

            // Test SetPrice
            Console.WriteLine("\n========== SetPrice Test ==========");
            t1.SetPrice(150);
            t1.SetPrice(100, 1.5);

            t2.Price = 200;
            t3.Price = 180;

            // Add tickets
            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            // Print all
            cinema.PrintAllTickets();

            // Process single
            TicketProcessor.ProcessTicket(t2);

            cinema.Close();
            #endregion
        }
    }
}
