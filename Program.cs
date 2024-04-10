// Из имеющегося массива строк формирует новый
// массив из строк, длина которых меньше, либо равна 3 символам


int FindCount(string[] originalArray)   // Считаем количество строк, удовлетворяющих условию
{    int count = 0;    
    foreach (string str in originalArray)
    {
        if (str.Length <= 3)
        {
           count++;
        }
    }
    return count;
}

// Заполняем новый массив строками, удовлетворяющими условию
string[] FindArray(string[] originalArray, int count)
{
    string[] newArray = new string[count];      // Создаем новый массив нужного размера
    int index = 0;
    foreach (string str in originalArray)
    {
        if (str.Length <= 3)
        {
            newArray[index] = str;
            index++;
        }
    }

        return newArray;
}

string[] originalArray = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };
int count = FindCount(originalArray); 

string[] newArray1 = FindArray(originalArray, count);

Console.WriteLine("Новый массив строк:");       // Выводим новый массив строк
    foreach (string str in newArray1)
    {
        Console.WriteLine(str);
    }