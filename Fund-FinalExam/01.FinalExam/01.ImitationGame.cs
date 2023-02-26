using System.Text;

string input = Console.ReadLine();
string command;
StringBuilder sb = new StringBuilder();
sb.Append(input);
while ((command = Console.ReadLine()) != "Decode")
{
    string[] commandArg = command.Split("|");
    
    string comm = commandArg[0];
   
    if (comm == "Move")
    {
        int subLenght = int.Parse(commandArg[1]);
        string sub = sb.ToString().Substring(0, subLenght);
        sb.Remove(0, subLenght);
        sb.Append(sub);
       
        
    }
    else if (comm == "Insert")
    {
        int index = int.Parse(commandArg[1]);
        string value = commandArg[2];
        sb.Insert(index, value);


    }
    else if (comm == "ChangeAll")
    {
        string subStr = commandArg[1];
        string replacement = commandArg[2];

        sb.Replace(subStr, replacement);
        
    }
}
Console.WriteLine($"The decrypted message is: {sb}");