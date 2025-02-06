class lab7
{
    static void Main(string[] args)
    {
        Console.WriteLine(BuyingMovieTickets(3));
        Console.WriteLine(BuyingMovieTickets(4));
        Console.WriteLine(BuyingMovieTickets(5));
    }

    static double BuyingMovieTickets(int ticketCount)
    {
        double ticketPrice = 1800;

        double[] discounts = {0.10, 0.15,0.20};
        double totalCost = ticketCount * ticketPrice * (1 - discounts[ticketCount - 3]);

        return totalCost;
    }
}