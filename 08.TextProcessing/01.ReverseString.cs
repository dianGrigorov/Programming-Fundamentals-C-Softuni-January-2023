
string command;

while ((command = Console.ReadLine()) != "end")
{
    string reverseWord = string.Empty;

    for (int i = command.Length - 1; i >= 0; i--)
    {
        reverseWord += command[i];
    }
    Console.WriteLine($"{command} = {reverseWord}");
}
