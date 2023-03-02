
int n = int.Parse(Console.ReadLine());
Dictionary<string, int> carDistance = new Dictionary<string, int>();
Dictionary<string, int> carFuel = new Dictionary<string, int>();

for (int i = 0; i < n; i++)
{
    string[] cars = Console.ReadLine().Split("|");
    string model = cars[0];
    int km = int.Parse(cars[1]);
    int fuel = int.Parse(cars[2]);

    if (!carDistance.ContainsKey(model))
    {
        carDistance.Add(model, km);
        carFuel.Add(model, fuel);
    }
}

string command;
while ((command = Console.ReadLine()) != "Stop")
{
    string[] commArg = command.Split(" : ");
    string comm = commArg[0];

    if (comm == "Drive")
    {
        string car = commArg[1];
        int distance = int.Parse(commArg[2]);
        int fuel = int.Parse(commArg[3]);

        if (carFuel[car] < fuel ) 
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }
        else
        {
            carDistance[car] += distance;
            carFuel[car] -= fuel;
            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
        }
        if (carDistance[car] > 100000)
        {
            carDistance.Remove(car);
            carFuel.Remove(car);
            Console.WriteLine("Time to sell the {car}!");
        }
    }
    else if (comm == "Refuel")
    {
        string car = commArg[1];
        int fuel = int.Parse(commArg[2]);

        carFuel[car] += fuel;

        if (carFuel[car] > 75)
        {
           
            Console.WriteLine($"{car} refueled with {75 - (carFuel[car] -= fuel)} liters"); // 50 50 = 100 75
            carFuel[car] = 75;
        }
        else
        {
            Console.WriteLine($"{car} refueled with {fuel} liters");
            
        }
    }
    else if (comm == "Revert")
    {
        string car = commArg[1];
        int km = int.Parse(commArg[2]);

        carDistance[car] -= km;
        if (carDistance[car] < 10000)
        {
            carDistance[car] = 10000;
        }
        else
        {
            Console.WriteLine($"{car} mileage decreased by {km} kilometers");
        }
    }
}

foreach (var (key, value) in carDistance)
{
    foreach (var item in carFuel)
    {
        if (key == item.Key)
        {
            Console.WriteLine($"{key} -> Mileage: {value} kms, Fuel in the tank: {item.Value} lt.");
        }
    }
}