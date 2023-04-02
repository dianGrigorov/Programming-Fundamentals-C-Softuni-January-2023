using System.Globalization;

string spell = Console.ReadLine();

string command;

while ((command = Console.ReadLine()) != "Abracadabra")
{

    string[] commArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string curComm = commArg[0];
    if (curComm == "Abjuration")
    {
        spell = spell.ToUpper();
        Console.WriteLine(spell);
    }
    else if (curComm == "Necromancy")
    {
        spell = spell.ToLower();
        Console.WriteLine(spell);

    }

    else if (curComm == "Illusion")
    {
        int index = int.Parse(commArg[1]);
        if (index >= 0 && index < spell.Length)
        {
            spell = spell.Remove(index, 1);
           
            string newChar = commArg[2];
            spell = spell.Insert(index, newChar);

            Console.WriteLine("Done!");
        }
        else
        {
            Console.WriteLine("The spell was too weak.");
        }
        
    }
    else if (curComm == "Divination")
    {
        string firstString = commArg[1];
        string secondString = commArg[2];
        if (spell.Contains(firstString))
        {
            spell = spell.Replace(firstString, secondString);
            Console.WriteLine(spell);
        }
        
    }
    else if (curComm == "Alteration")
    {
        string substring = commArg[1];
        if (spell.Contains(substring))
        {
            int indexOfSub = spell.IndexOf(substring);
            spell = spell.Remove(indexOfSub, substring.Length);
            Console.WriteLine(spell);
        }
    }
    else
    {
        Console.WriteLine("The spell did not work!");
    }
}