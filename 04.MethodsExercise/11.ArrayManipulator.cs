
int[] arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] cmdArg = command.Split(' ');
    string cmdType = cmdArg[0];

    if (cmdType == "exchange")
    {
        int index = int.Parse(cmdArg[1]);

        if (index < 0 || index >= arr.Length) // Validate the index
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        arr = ExchangeArray(arr, index);
    }
    else if (cmdType == "max")
    {
        string evenOrOddArg = cmdArg[1];
        int indexOfMaxEl = IndexOfMaxOddOrEvenElements(arr, evenOrOddArg);
        if (indexOfMaxEl == -1)
        {
            Console.WriteLine("No matches");
            continue;

        }
        Console.WriteLine(indexOfMaxEl);
    }
    else if(cmdType == "min") 
    {
        string evenOrOddArg = cmdArg[1];
        int indexOfMinEl = IndexOfMinOddOrEvenElements(arr , evenOrOddArg);
        if (indexOfMinEl == -1)
        {
            Console.WriteLine("No matches");
            continue;
        }
        Console.WriteLine(indexOfMinEl);
    }
    else if (cmdType == "first")
    {
        int count = int.Parse(cmdArg[1]);
        string oddOrEvenArg = cmdArg[2];
        int[] firstIndex= new int[count];
        if (count > arr.Length)
        {
            Console.WriteLine("Invalid count");
            continue;
        }
       
        firstIndex = GetFirstOddOrEvenElements(arr, count, oddOrEvenArg);
        Console.WriteLine($"[{string.Join(", ",firstIndex)}]");
       

    }
    else if (cmdType == "last")
    {
        int count = int.Parse(cmdArg[1]);
        string oddOrEvenArg = cmdArg[2];
        int[] firstIndex = new int[count];
        if (count > arr.Length)
        {
            Console.WriteLine("Invalid count");
            continue;
        }
        
        firstIndex = GetLastOddOrEvenElements(arr, count, oddOrEvenArg);

        Console.WriteLine($"[{string.Join(", ", firstIndex)}]");
    }
}
Console.WriteLine($"[{string.Join(", ", arr)}]");
             // Return modified version of the array
static int[] ExchangeArray(int[] originalArr, int index)
{
    int[] modifiedArr = new int[originalArr.Length];
    int modifiedIndex = 0;
    for (int i = index + 1; i < originalArr.Length; i++)
    {
        modifiedArr[modifiedIndex++] = originalArr[i];
    }
    for (int i = 0; i <= index; i++)
    {
        modifiedArr[modifiedIndex++] = originalArr[i];
    }
    return modifiedArr;
}

             // Return index of max odd/even element
             // If there is no matching elements it returns -1
static int IndexOfMaxOddOrEvenElements(int[] arr, string evenOrOddArg)
{
    // Defaut value of maxIndex which means there is no match
    int index = -1;
    int currMax = int.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        int currNum = arr[i];

        if (evenOrOddArg == "even" && currNum % 2 == 0)
        {
            if (currNum >= currMax)
            {
                currMax = currNum;
                index = i;
            }
        }
        if (evenOrOddArg == "odd" && currNum % 2 != 0)
        {
            if (currNum >= currMax)
            {
                currMax = currNum;
                index = i;
            }
        }
    }
    return index;
}

            // Return index of max odd/even element
            // If there is no matching elements it returns -1

static int IndexOfMinOddOrEvenElements(int[] arr, string evenOrOddArg)
{
    int index = -1;
    int currMin = int.MaxValue;

    for (int i = 0; i < arr.Length; i++)
    {
        int curNum = arr[i];

        if (evenOrOddArg == "even" && curNum % 2 == 0)
        {
            if (curNum <= currMin)
            {
                currMin = curNum;
                index = i;
            }
        }
        if (evenOrOddArg == "odd" && curNum % 2 != 0)
        {
            if (curNum <= currMin)
            {
                currMin = curNum;
                index = i;
            }
        }
    }
    return index;
}

            // Return first counted odd/even elements
static int[] GetFirstOddOrEvenElements(int[] arr, int count, string oddOrEvenArg)
{
    int[] firstIndexes= new int[count];
    int currNum = 0;
    int cntIndex = 0;
    if (oddOrEvenArg == "even")
    {
        for (int i = 0; i < arr.Length; i++)
        {
            currNum = arr[i];
            if (currNum % 2 == 0)
            {
                firstIndexes[cntIndex++] = currNum;
              
                if (cntIndex == count)
                {
                    break;
                }
            }
        }
    }
    if (oddOrEvenArg == "odd")
    {
        for (int i = 0; i < arr.Length; i++)
        {
            currNum = arr[i];
            if (currNum % 2 != 0)
            {
                firstIndexes[cntIndex++] = currNum;
               
                if (cntIndex == count)
                {
                    break;
                }
            }
        }
    }
    firstIndexes = ResizeArray(firstIndexes, cntIndex);
    return firstIndexes;
}
                // Return first counted odd/even elements
static int[] GetLastOddOrEvenElements(int[] arr, int count, string oddOrEvenArg)
{
    int[] firstIndexes = new int[count];
    int currNum = 0;
    int cntIndex = 0;
    if (oddOrEvenArg == "even")
    {
        for (int i = arr.Length - 1; i >=0; i--)
        {
            currNum = arr[i];
            if (currNum % 2 == 0)
            {
                firstIndexes[cntIndex++] = currNum; 
                if (cntIndex == count)
                {
                    break;
                }
            }
        }
    }
    if (oddOrEvenArg == "odd")
    {
        for (int i = arr.Length -1; i >= 0; i--)
        {
            currNum = arr[i];
            if (currNum % 2 != 0)
            {
                firstIndexes[cntIndex++] = currNum;
               
                if (cntIndex == count)
                {
                    break;
                }
            }
        }
    }
    firstIndexes = ResizeArray(firstIndexes, cntIndex);
    Array.Reverse(firstIndexes);

    return firstIndexes;
}

static int[] ResizeArray(int[] arr, int count)
{
    int[] newArray = new int[count];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}
