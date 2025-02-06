class lab3
{
    static void Main(string[] args)
    {
        Console.WriteLine(FuelConsumption(60).ToString());
    }

    static double FuelConsumption(double fuel)
    { 
        double fuelConsumption = 7.5;
        double distance = (fuel / fuelConsumption) * 100;

        return distance;
    }
}