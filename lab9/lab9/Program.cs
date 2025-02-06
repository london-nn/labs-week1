class lab9
{
    static void Main(string[] args)
    {
        HeightInFeetAndInches();
    }

    static void HeightInFeetAndInches()
    {
        double heightCm = 182;
        double totalInches = heightCm / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;
        Console.WriteLine("Feet: " + feet + " Inches: " + inches);
    }
}