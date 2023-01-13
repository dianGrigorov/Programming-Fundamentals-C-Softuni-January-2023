
int fieldSize = int .Parse(Console.ReadLine());
int[] field = new int[fieldSize];
int[] ladybugIndexes = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();
// Spawn ladybug and valdate the field indexes
foreach (int i in ladybugIndexes)
{
    if (i >= 0 && i < field.Length)
    {
        field[i] = 1;
    }
}
string command;
// Proces the game
while ((command = Console.ReadLine()) != "end")
{
    string[] cmdArg = command
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int ladybugIn = int.Parse(cmdArg[0]);
    string direction = cmdArg[1];
    int flyLenght = int.Parse(cmdArg[2]);
    // Validate ladybugIndex is inside the field
        if (ladybugIn < 0 || ladybugIn >= field.Length)
        {
        //Invalid index => Nothing hapend
        continue;
        }
        if (field[ladybugIn] == 0)
        {
        //there is no leydybug in the index => Nothing hapend
        continue;
        }
    // Try to proceed move
    field[ladybugIn] = 0;
    if (direction == "left")
    {
        flyLenght *= -1;
    }
    int nextIndex = ladybugIn + flyLenght;
    while (nextIndex > 0 && nextIndex < field.Length && field[nextIndex] == 1)
    {
        nextIndex += flyLenght;
    }
    if (nextIndex <0 || nextIndex >= field.Length)
    {
        continue;
    }
    field[nextIndex] = 1;

}
Console.WriteLine(string.Join(" ", field));