
Dictionary<string, int> resources = new Dictionary<string, int>();

string input;
while ((input = Console.ReadLine()) != "stop")
{
    string resource = input;
    int quantity = int.Parse(Console.ReadLine());

    if (!resources.ContainsKey(resource))
    {
        resources.Add(resource, 0);
    }
    resources[resource] += quantity;
}

foreach(var resource in resources)
{
    Console.WriteLine($"{resource.Key} -> {resource.Value}");
}