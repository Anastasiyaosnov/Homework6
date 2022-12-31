// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int lenght)
{
    int[] first = new int[lenght];
    for (int i = 0; i < first.Length; i++)
    {
        first[i] = Promt("Введите следующее число");
    }
    return first;
}

void PrintArray(int[] array1)
{
    int lenght1 = array1.Length;
    for (int i = 0; i < lenght1; i++)
        Console.Write($"{array1[i]} ");
}

int Compare(int[] second)
{
    int index = 0;
    foreach (int element in second)
    {
        if (element > 0)
        {
            index ++;
        }
    }
    return index;
}

int UserLenght = Promt("Сколько чисел Вы планируете ввести?");
int [] userArray = CreateArray(UserLenght);
Console.Write("Получены следующие числа: ");
PrintArray(userArray);
Console.WriteLine();
Console.WriteLine($"Посчитано, что среди них чисел больше 0 > {Compare(userArray)}");




