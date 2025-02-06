class lab6
{
    static void Main(string[] args)
    {
        Console.WriteLine(ArithmeticMean([15, 22, 38, 47]));
    }

    static double ArithmeticMean(List<int> numbers)
    {
        

        int add = numbers[0] * numbers[1];
        numbers.Add(add);
        double count = numbers.Count();
        double arithmeticMean = numbers.Sum() / count;

        return arithmeticMean;
    }
}