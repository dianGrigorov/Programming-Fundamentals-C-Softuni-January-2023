
Dictionary<string, string> parkingList= new Dictionary<string, string>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] commandArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string currCom = commandArg[0];
    string userName = commandArg[1];
    if (currCom == "register")
    {
       
        string licensePlate = commandArg[2];

        if (!parkingList.ContainsKey(userName))
        {
            parkingList.Add(userName, licensePlate);
            Console.WriteLine($"{userName} registered {licensePlate} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
        }
    }
    else if (currCom == "unregister")
    {
        
        if (parkingList.ContainsKey(userName))
        {
            parkingList.Remove(userName);
            Console.WriteLine($"{userName} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {userName} not found");
        }
    }
}
foreach (var user in parkingList)
{
    Console.WriteLine($"{user.Key} => {user.Value}");
}