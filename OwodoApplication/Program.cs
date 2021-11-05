using System;

namespace OwodoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //brings 100
            //price is 100
            //100 + 31 (daily) = 3100
            //50 + 31 (monthly) = 1550

            //initial money 100...get from members
            //price per tickect..set ourselves... daily 100 (3100) monthly 50 (1550)
            //type of  ticket plan ...get from memeber

            //calculate price ..software(us)
            //to know which tickect to give user
            //show the memeber his/her total cost
            //give chairman 65% of total earnings

            OwodaApp jemila = new OwodaApp();

            Console.WriteLine("Buy Ticket? y/n");
            string answer = Console.ReadLine();
            while (answer == "y")
            {
                jemila.BuyTicket();
                Console.WriteLine("Buy Ticket? y/n");
                answer = Console.ReadLine();
            }
            
            jemila.Summary();

           
        }
    }

    class OwodaApp
    {
        public string TicketType { get; set; }

        public double ticketPrice = 100.00;
        public int ticketsSold = 0;
        private double totalAmount = 0.00;


        public void BuyTicket()
        {
            //prompt to get type of ticket
            Console.WriteLine("what kind of ticket do you want daily or monthly");
            TicketType = Console.ReadLine();
            double price = findTicketPrice(TicketType);
            //generate random number as ticket id
            Random rnd = new Random();
            int num = rnd.Next();
            //show user ticket buying is successful
            Console.WriteLine("ticket brought, your ticket number is " + num);
            ticketsSold = ticketsSold + 1;
            totalAmount = totalAmount + price;

        }

        public double findTicketPrice(string choiceOfTicket)
        {
            if (choiceOfTicket == "daily")
            {
                return ticketPrice;
            }
            
            else
            {
                return (ticketPrice / 2) * 31;
            }
        }

        public void Summary()
        {
            //display ticketsSold
            Console.WriteLine("ticket sold is " + ticketsSold);
            //display total ammount
            Console.WriteLine("total amount of ticket sold is " + totalAmount);
            double ogaShare = 0.65 * totalAmount;
            //display ogashare
            Console.WriteLine($"Total of Oga Share is {ogaShare}");
            double remaining = totalAmount - ogaShare;
            //make yourself happy
            Console.WriteLine($"my own balance is {remaining}");
        }
 
         

    }
}
