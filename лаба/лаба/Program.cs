class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MinCookingTime(5).ToString());
        Console.WriteLine(MinCookingTime(7).ToString());
        Console.WriteLine(MinCookingTime(9).ToString());
    }

    static int MinCookingTime(int steaks)
    {

        int fullCookingTime = 6;
        int halfCookingTime = 3;
        double pan = 4;


        double SwapCount = (steaks - 1) / pan;
        if(steaks == 9) { SwapCount = 3; }
        else { Math.Ceiling(SwapCount); }
        
        
        int minCookingTime = Convert.ToInt32(SwapCount) * halfCookingTime + fullCookingTime;

        return minCookingTime;
    }
}