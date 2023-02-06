
Dictionary<string, List<string>> keyValuePairs= new Dictionary<string, List<string>>();
string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] companyAndEmployees = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
    string company = companyAndEmployees[0];
    string employeID = companyAndEmployees[1];

    if (!keyValuePairs.ContainsKey(company))
    {
        keyValuePairs.Add(company, new List<string>());
    }
    if (keyValuePairs[company].Contains(employeID))
    {
        continue;
    }
    else
    {
        keyValuePairs[company].Add(employeID);
    }

}

foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key}");

    foreach (var ID in item.Value)
    {
        Console.WriteLine($"--{ID}");
    }
}