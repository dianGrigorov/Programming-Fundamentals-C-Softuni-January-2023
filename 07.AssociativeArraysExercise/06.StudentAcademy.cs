

using System.Xml.Linq;

int n = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> studentsInfo = new Dictionary<string, List<decimal>>();

for(int i = 0;i < n; i++)
{
    string studentName = Console.ReadLine();
    decimal grade = decimal.Parse(Console.ReadLine());

    if (!studentsInfo.ContainsKey(studentName))
    {
        studentsInfo.Add(studentName, new List<decimal>());
    }

    studentsInfo[studentName].Add(grade);
}


foreach (var item in studentsInfo)
{
    
    if (item.Value.Average(x => x) >= 4.5m)
    {
        Console.WriteLine($"{item.Key} –> {item.Value.Average():f2}");
    }
}