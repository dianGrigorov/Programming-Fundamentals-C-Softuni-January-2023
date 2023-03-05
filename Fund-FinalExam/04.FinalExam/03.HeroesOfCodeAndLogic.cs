
int n = int.Parse(Console.ReadLine());

Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

for (int i = 0; i < n; i++)
{
    //"{hero name} {HP} {MP}
    string[] heroInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string heroName = heroInfo[0];
    int HP = int.Parse(heroInfo[1]);
    int MP = int.Parse(heroInfo[2]);
    if (HP > 100)
    {
        HP = 100;
    }
    if (MP > 200)
    {
        MP = 200;
    }

    if (!heroes.ContainsKey(heroName))
    {
        heroes.Add(heroName, new List<int>() { HP, MP });
    }
}

string command;

while ((command = Console.ReadLine()) != "End")
{
    string[] commArg = command.Split(" - ");
    string currComm = commArg[0];
    string heroName = commArg[1];

    if (currComm == "CastSpell")
    {
        //{MP needed} – {spell name}"

        int neadedMP = int.Parse(commArg[2]);
        string spellName = commArg[3];

        if (heroes[heroName][1] >= neadedMP)
        {
            heroes[heroName][1] -= neadedMP;
            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
        }
        else
        {
            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
        }
    }
    else if (currComm == "TakeDamage")
    {
        //{damage} – {attacker}"
        int damage = int.Parse(commArg[2]);
        string attacker = commArg[3];

        heroes[heroName][0] -= damage;
        if (heroes[heroName][0] > 0)
        {
            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
        }
        else
        {
            Console.WriteLine($"{heroName} has been killed by {attacker}!");
            heroes.Remove(heroName);
        }
    }
    else if (currComm == "Recharge")
    {
        int amountMP = int.Parse(commArg[2]);
        heroes[heroName][1] += amountMP;
                             
        if (heroes[heroName][1] > 200)
        {
            int restoreMP = 200 - (heroes[heroName][1] -= amountMP);
            heroes[heroName][1] = 200;
            Console.WriteLine($"{heroName} recharged for {restoreMP} MP!");
        }
        else
        {
            Console.WriteLine($"{heroName} recharged for {amountMP} MP!");
        }
    }
    else if (currComm == "Heal")
    {
        int amountHP = int.Parse(commArg[2]);
        heroes[heroName][0] += amountHP;
                              
        if (heroes[heroName][0] > 100)
        {
            int restoreHP = 100 - (heroes[heroName][0] -= amountHP);
            heroes[heroName][0] = 100;
            Console.WriteLine($"{heroName} healed for {restoreHP} HP!");
        }
        else
        {
            Console.WriteLine($"{heroName} healed for {amountHP} HP!");
        }
    }
}
foreach (var hero in heroes)
{
    Console.WriteLine(hero.Key);
    Console.WriteLine($" HP: {hero.Value[0]}");
    Console.WriteLine($" MP: {hero.Value[1]}");
}