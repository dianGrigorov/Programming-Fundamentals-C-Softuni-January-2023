List<Students> students = new List<Students>();

string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] studentInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string firstName = studentInput[0];
    string lastName = studentInput[1];
    int age = int.Parse(studentInput[2]);    
    string town = studentInput[3];

    Students currStudent = new Students(firstName, lastName, age, town);
    students.Add(currStudent);

}

string filterCity = Console.ReadLine();

foreach (Students student in students)
{
    if (student.Town == filterCity)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}
public class Students
{
    public Students(string firstName, string lastName, int age, string town)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Town = town;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string Town { get; set; }
}