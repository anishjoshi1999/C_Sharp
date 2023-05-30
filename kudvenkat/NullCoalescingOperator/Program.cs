using System;
/*Null Coalescing Operator */
class Program
{
    static void Main(string[] args)
    {
        int? TicketsOnSale = null;
        /*Null Coalescing Operator */
        int AvailableTickets = TicketsOnSale ?? 0;

        //if(TicketsOnSale == null)
        //{
        //    AvailableTickets = 0;
        //}else
        //{
        //    AvailableTickets = TicketsOnSale.Value;
        //}
        Console.WriteLine("AvailableTickets = {0}",AvailableTickets);
    }
}