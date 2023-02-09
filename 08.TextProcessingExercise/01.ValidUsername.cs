

string[] userName = Console.ReadLine().Split(", ");

string validUserName = string.Empty;

foreach (var name in userName)
{
    bool notContains = false;

    foreach (var ch in name)
    {
        if (Char.IsLetterOrDigit(ch) || ch == '-' || ch =='_')
        {
            notContains = true;
           
        }
        else
        {
            notContains = false;
            break;
        }
        
    }
    if (notContains && name.Length >= 3 && name.Length <= 16)
    {
        Console.WriteLine(name);
    }
}