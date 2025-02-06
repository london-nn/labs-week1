class lab8
{
    static void Main(string[] args)
    {
        Console.WriteLine(ChangeFromPurchase() + " KZT");
    }

    static double ChangeFromPurchase()
    {
        double phonePrice = 150000;
        double headphonesPrice = 12000;
        double phoneCasePrice = 3500;
        double amountGiven = 200000;

        double totalPurchase = phonePrice + headphonesPrice + phoneCasePrice;
        double change = amountGiven - totalPurchase;

        return change;
    }
}