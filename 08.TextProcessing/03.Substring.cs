
string key = Console.ReadLine();
string str = Console.ReadLine();


while (str.Contains(key))
{
    int index = str.IndexOf(key);
  
    str = str.Remove(index, key.Length);
}

Console.WriteLine(str);