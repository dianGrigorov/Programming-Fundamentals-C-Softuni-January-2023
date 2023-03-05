
using System.Text;

string password = Console.ReadLine();

string command;

while ((command = Console.ReadLine()) != "Done")
{
    string[] commArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string curComm = commArg[0];

    if (curComm == "TakeOdd")
    {
        string newPassword = string.Empty;
        for (int i = 0; i < password.Length; i++)
        {
            if (i % 2 != 0)
            {
              newPassword += password[i];
            }
        }
        Console.WriteLine(newPassword);
        password = newPassword;
    }
    else if (curComm == "Cut")
    {
        int index = int.Parse(commArg[1]);
        int lenght = int.Parse(commArg[2]);

        password =  password.Remove(index, lenght);
        Console.WriteLine(password);
    }
    else if (curComm == "Substitute")
    {
        string subStr = commArg[1];
        string substitute = commArg[2];
        if (password.Contains(subStr))
        {
            password = password.Replace(subStr, substitute);
            Console.WriteLine(password);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }
    }
}
Console.WriteLine($"Your password is: {password}");