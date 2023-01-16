
string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

CalculatePrice(product, quantity);
static void CalculatePrice(string product, int quantity)
{
    if (product == "coffee")
    {
        decimal sum = quantity * 1.50m;
        Console.WriteLine($"{sum:f2}");
    }
    else if (product == "water")
    {
        decimal sum = quantity * 1.00m;
        Console.WriteLine($"{sum:f2}");
    }
    else if (product == "coke")
    {
        decimal sum = quantity * 1.40m;
        Console.WriteLine($"{sum:f2}");
    }
    else if (product == "snacks")
    {
        decimal sum = quantity * 2.00m;
        Console.WriteLine($"{sum:f2}");
    }
}