// Собрать строку с числами от a до b, a<=b
// string NumbersRec(int a, int b)
// {
//     if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }
// Console.WriteLine(NumbersRec(5,20));

// Сумма чисел от 1 до n
// int SumRec(int n)
// {
//     if(n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumRec(8));

// Факториал числа
// int FactorialRec(int n)
// {
//     if(n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialRec(7));

// Вычислить а в степени n
// int PowerRec(int a, int n)
// {
//     if(n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }
// Console.WriteLine(PowerRec(5,3));

// В алфавите имеются 4 буквы (а, и, с, в). Показать все слова из Т букв, которые можно построить из букв этого алфавита
int n = 1;
void FindWords(string alfabet, char[] word, int length = 0)
{
    if(length == word.Length)
    {
        Console.WriteLine($"{n++} {new string(word)}"); return;
    }
    for (int i = 0; i < alfabet.Length; i++)
    {
        word[length] = alfabet[i];
        FindWords(alfabet, word, length + 1);
    }
}

FindWords("аисв", new char[3]);