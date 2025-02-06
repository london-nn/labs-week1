class TestClass
{
    static void Main(string[] args)
    {
        MovieDuration();
    }

    static void MovieDuration()
    {
        int firstMovie = 132;
        int secondMovie = 148;
        int thirdMovie = 175;

        int totalMinutes = firstMovie + secondMovie + thirdMovie;
        int hours = totalMinutes / 60;
        int minutes = totalMinutes % 60;
        Console.WriteLine(hours +" : " + minutes);
    }
}