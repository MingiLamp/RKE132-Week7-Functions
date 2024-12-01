
class TempConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1: Convert Celsius to Fahrenheit");
        Console.WriteLine("2: Convert Fahrenheit to Celsius");
        int choice = Int32.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter temperature in Celsius:");
                double celsius = Double.Parse(Console.ReadLine());
                ConvertToFahrenheit(celsius);
                break;
            case 2:
                Console.WriteLine("Enter temperature in Fahrenheit:");
                double fahrenheit = Double.Parse(Console.ReadLine());
                ConvertToCelsius(fahrenheit);
                break;
        }
    }

    static void ConvertToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F.");
    }

    static void ConvertToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C.");
    }
}
