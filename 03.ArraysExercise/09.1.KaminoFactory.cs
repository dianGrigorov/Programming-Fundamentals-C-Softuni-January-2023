
int n = int.Parse(Console.ReadLine());
int[] bestDna = new int[n];
int sample = 0;
int bestSample = 0;
int bestCnt = 0;
int bestSum = 0;
int bestDnaIndex = 0;
int statrIndex = 0;

string command;
while ((command = Console.ReadLine()) != "Clone them!")
{

    sample++;
    int[] dna = command
    .Split("!", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
    int sum = 0;
    int cntSequence = 1;
    for (int i = 0; i < dna.Length - 1; i++)
    {

        if (dna[i] == 1 && dna[i] == dna[i + 1])
        {
            if (cntSequence == 1)
            {
                statrIndex = i;
            }
            cntSequence++;
        }
    }
    for (int i = 0; i < dna.Length; i++)
    {
        if (dna[i] == 1)
        {
            sum++;
        }
    }
    if (cntSequence > bestCnt)
    {
        bestCnt = cntSequence;
        bestDna = dna;
        bestSample = sample;
        bestSum = sum;
        bestDnaIndex = statrIndex;
    }
    else if (cntSequence == bestCnt)
    {
        if (statrIndex < bestDnaIndex)
        {
            bestDna = dna;
            bestSample = sample;
            bestSum = sum;
            bestDnaIndex = statrIndex;
        }
        else if (statrIndex == bestDnaIndex)
        {
            if (sum > bestSum)
            {
                bestDna = dna;
                bestSample = sample;
                bestSum = sum;
            }
        }
    }


}
Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", bestDna));
