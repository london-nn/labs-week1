class TestClass
{
    static void Main(string[] args)
    {
        CircumferenceAndArea();
    }

    static void CircumferenceAndArea()
    {
        double radius = 9.5; 
        double pi = 3.141592; 
        double circumference = 2 * pi * radius; 
        double area = pi * radius * radius;
        Console.WriteLine("Circumference: " + circumference);
        Console.WriteLine("Area: " + area);
    }
}