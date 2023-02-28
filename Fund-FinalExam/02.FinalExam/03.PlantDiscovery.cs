
using System.Linq;

int n = int.Parse(Console.ReadLine());

Dictionary<string, int> plantRarity = new Dictionary<string, int>();
Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();

for (int i = 0; i < n; i++)
{
    string[] plantInfo = Console.ReadLine().Split("<->");
    string plantName = plantInfo[0];
    int rarity = int.Parse(plantInfo[1]);
    if (!plantRarity.ContainsKey(plantName))
    {
        plantRarity.Add(plantName, rarity);
        plantRating.Add(plantName, new List<double>());
    }
    else
    {
        plantRarity[plantName] = rarity;
    }
}

string commandInfo;

while ((commandInfo = Console.ReadLine()) != "Exhibition")
{
    string[] commandArg = commandInfo.Split(new char[] { '-', ':' ,' '}, StringSplitOptions.RemoveEmptyEntries);
    string currComm = commandArg[0];
    string plantName = commandArg[1];

    if (currComm == "Rate")
    {
        double rating = double.Parse(commandArg[2]);

        if (!plantRarity.ContainsKey(plantName))
        {
            Console.WriteLine("error");
        }
        else
        {
            plantRating[plantName].Add(rating);
        }
    }
    else if (currComm == "Update")
    {
        int rarity = int.Parse(commandArg[2]);

        if (plantRarity.ContainsKey(plantName))
        {
            plantRarity[plantName] = rarity;
        }

        else
        {
            Console.WriteLine("error");
        }
    }
    else if (currComm == "Reset")
    {
        if (plantRating.ContainsKey(plantName))
        {
            plantRating[plantName].Clear();
        }
        else
        {
            Console.WriteLine("error");
        }
    }

}
double average = 0;

Console.WriteLine("Plants for the exhibition:");

foreach (var plant in plantRarity)
{
    foreach (var item in plantRating)
    {
        
       
        if (plant.Key == item.Key)
        {
            if (item.Value.Count > 0)
            {
                average = item.Value.Average();

            }
            Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {average:f2}");
        }
    }
   
}