// Из имеющегося массива строк формирует новый
// массив из строк, длина которых меньше, либо равна 3 символам


int FindCount(string[] originalArray)
{    int count = 0;
    // Считаем количество строк, удовлетворяющих условию
    foreach (string str in originalArray)
    {
        if (str.Length <= 3)
        {
           count++;
        }
    }
    return count;
}

string[] originalArray = { "Hello", "2", "world", ":-)" };
int count = FindCount(originalArray);
Console.WriteLine(count);