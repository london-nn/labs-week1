class lab13
{
    static void Main(string[] args)
    {
        PriceOfApples();
    }

    static void PriceOfApples()
    {
        double priceFor5Kg = 3200;
        double pricePerKg = priceFor5Kg / 5;
        double newPricePerKg = pricePerKg * (1 + 0.12);
        double costFor7Kg = newPricePerKg * 7;
        Console.WriteLine(costFor7Kg);
    }
}