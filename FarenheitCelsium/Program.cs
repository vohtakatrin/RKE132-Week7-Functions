Console.WriteLine("Choose convertation:");
Console.WriteLine("Fahrenheit to celsius - 1");
Console.WriteLine("Celsius to fahrenheit - 2");
int choice = Int32.Parse(Console.ReadLine());
if (choice == 1)
{
    Console.WriteLine("Enter temperature in fahrenheit:");
    double fahrenheit = Double.Parse(Console.ReadLine());
    ConvertToCelsius(fahrenheit);
}
else if (choice == 2)
{
    Console.WriteLine("Enter temperature in Celsius:");
    double celsius = Double.Parse(Console.ReadLine());
    ConvertToFahrenheit(celsius);
}
else
{
    Console.WriteLine("Please write a number.");
}
    static void ConvertToCelsius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"{fahrenheit} Fahrenheit = {celsius} Celsius degrees.");
}

static void ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9) / 5 + 32;
    Console.WriteLine($"{celsius} Celsius = {fahrenheit} Fahrenheit degrees.");
}
