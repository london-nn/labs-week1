class lab10
{
    static void Main(string[] args)
    {
        Temperature();
    }

    static void Temperature()
    {
        double dayTempC = 20; 
        double nightTempC = dayTempC * (1 - 0.12); 
        double nightTempF = nightTempC * 9 / 5 + 32; 
        Console.WriteLine(nightTempF);
    }
}