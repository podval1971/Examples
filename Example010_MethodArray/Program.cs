int [] array = {51,26,13,54,75,26,71,8,19,12,34,67,8};
int n = array.Length;
int find = 8;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }
   index++; 
}
