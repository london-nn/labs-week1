class lab2
{
    static void Main(string[] args)
    {
        Console.WriteLine(TotalWeightOfProducts([2.4, 3.6, 1.8, 2.2]).ToString() + " kilograms");
    }

    static double TotalWeightOfProducts(double[] productsWeight)
    {

        double sum = productsWeight.Sum();

        double result = sum / 3;

        return result;
    }
}