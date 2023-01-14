int n = int.Parse(Console.ReadLine());
int[] colectSnm = new int[n];

for (int i = 0; i < n; i++)
{
    string[] sequences = Console.ReadLine().Split("", StringSplitOptions.RemoveEmptyEntries);

    foreach (var sequence in sequences)
    {

        foreach (var letter in sequence)
        {
            char curCh = letter;
            if (curCh == 'a' || curCh == 'A' ||
                curCh == 'e' || curCh == 'E' ||
                curCh == 'i' || curCh == 'I' ||
                curCh == 'o' || curCh == 'O' ||
                curCh == 'u' || curCh == 'U')

            {
                colectSnm[i] += curCh * sequence.Length;
            }
            else
            {
                colectSnm[i] += curCh / sequence.Length;
            }
        }
    }

}
Array.Sort(colectSnm);
foreach (var colect in colectSnm)
{
    Console.WriteLine(string.Join(" ", colect));
}
