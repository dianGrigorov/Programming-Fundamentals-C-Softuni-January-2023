using System.Numerics;

int biscuits = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());
BigInteger biscuitsProduce = BigInteger.Parse(Console.ReadLine());

BigInteger totalBiscuits = 0;

for (int i = 1; i <= 30; i++)
{
    if (i % 3 == 0)
    {
        double reduse = Math.Floor((biscuits * workers) * 0.75);
        totalBiscuits += (int)reduse;
    }
    else 
    {
        totalBiscuits += biscuits * workers;
    }
}
Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");

double difference = (double)BigInteger.Abs(totalBiscuits - biscuitsProduce);
double result = difference / (double)biscuitsProduce;


if (totalBiscuits > biscuitsProduce)
{
    
    Console.WriteLine($"You produce {result * 100:f2} percent more biscuits.");
}
else
{
    
    Console.WriteLine($"You produce {result * 100:f2} percent less biscuits.");
}
