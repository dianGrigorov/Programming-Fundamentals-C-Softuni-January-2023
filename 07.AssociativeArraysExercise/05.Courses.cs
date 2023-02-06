
Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();

string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] inputArg = input.Split(" : ");

    string courseName = inputArg[0];
    string studentName = inputArg[1];

    if (!courseInfo.ContainsKey(courseName))
    {
        courseInfo.Add(courseName, new List<string>());
    }
    courseInfo[courseName].Add(studentName);

}

foreach(var courseName in courseInfo)
{
    Console.WriteLine($"{courseName.Key}: {courseName.Value.Count}");

    foreach (var studentName in courseName.Value)
    {
        Console.WriteLine($"-- {studentName}");
    }
}