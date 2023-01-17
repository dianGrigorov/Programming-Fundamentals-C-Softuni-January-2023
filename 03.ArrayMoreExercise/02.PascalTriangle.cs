int n = int.Parse(Console.ReadLine());

int[] arr = null;
int[] previosArr= null;

for (int i = 1; i <= n; i++)
{
    arr = new int[i];
    arr[0] = 1;                    //The firs element is allways 1
    arr[arr.Length-1] = 1;         // The last element is allways1

    for (int j = 1; j < arr.Length -1; j++)     // Calculate column
    {
        arr[j] = previosArr[previosArr.Length - 1] + previosArr[j];
    }
    previosArr = arr;

    Console.WriteLine(string.Join(' ', arr));
}