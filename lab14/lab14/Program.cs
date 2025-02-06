class lab14
{
    static void Main(string[] args)
    {
        AveageSpeedOfCar();
    }

    static void AveageSpeedOfCar()
    {
        double firstDistance = 150;
        double firstTime = 3;
        double firstSpeed = firstDistance / firstTime;
        double secondDistance = 120;
        double secondSpeed = firstSpeed * 1.15;
        double secondTime = secondDistance / secondSpeed;
        double totalDistance = firstDistance + secondDistance;
        double totalTime = firstTime + secondTime;
        double averageSpeed = totalDistance / totalTime;
        Console.WriteLine("Average Speed: " + averageSpeed);
    }
}