// Двумерные массивы: string[,] table = new string[2,3]; int[,] matrix = new int[3,5]
string[,] table = new string[2, 5];
//String.Empty инициализация пустого массива
/*
table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows,columns]}-");
    }
}
*/
/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

// Рекурсия - функция, которая вызывает сама себя
// Рассчет факториала некоторого числа
/*
int Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}

for (int i = 1; i < 30; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/
// Числа Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
