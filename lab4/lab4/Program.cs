class lab4
{
    static void Main(string[] args)
    {
        Console.WriteLine(CurrencyExchange(100) + " tenge");
    }

    static double CurrencyExchange(int dollars)
    {
        int ExchangeRate = 475;
        double Comission = 1.5;

        double Exchange = (dollars * ExchangeRate);
        double percent = Exchange * Comission / 100;

        return Exchange - percent ;
    }
}