// See https://aka.ms/new-console-template for more information
int[] dizi = {5,2,7,6};

Console.WriteLine("dizinin önceki hhali" + dizi);
Yazdir(dizi);

SelectionSort(dizi);

Console.WriteLine("dizinin sonraki hali");
Yazdir(dizi);


static void SelectionSort(int[] dizi)
{
    for (int i = 0; i < dizi.Length-1; i++)
    {
        int minIndex = i;

        for (int j = 1; j < dizi.Length; j++)
        {
            if (dizi[j] < dizi[minIndex])
            {
                minIndex = j;
            }
        }
        int temp = dizi[i];
        dizi[i] = dizi[minIndex];
        dizi[minIndex] = temp;
    }
}

static void Yazdir(int[] dizi)
{
    foreach (int eleman in dizi)
    {
        Console.Write(eleman + " ");
    }
    Console.WriteLine();
}