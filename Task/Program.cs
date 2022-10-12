// Задача: Написать программу, которая из имеющегося 
// массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

Console.Clear();

void FillString(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент: ");
        string element = Console.ReadLine();
        str[i] = element;
    }
}

void NewString(string[] str)
{
    string[] newStr = new string[str.Length];
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length < 4)
        {
            newStr[count] = str[i];
            count++;
        }
    }
    PrintString(newStr);
}

void PrintString(string[] str)
{
    Console.WriteLine("Новый массив: ");
    for (int i = 0; i < str.Length; i++)
        Console.Write($"{str[i]} ");
}

Console.WriteLine("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] str = new string[size];
FillString(str);
NewString(str);
