void FillArray(int[] collectoin)
{
    int length = collectoin.Length;
    int index = 0;
    while (index < length)
    {
        collectoin[index] = new Random().Next(1,10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOff(int[] collectoin, int find)
{
    int count = collectoin.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collectoin[index] == find) 
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 4);
Console.WriteLine(pos);
