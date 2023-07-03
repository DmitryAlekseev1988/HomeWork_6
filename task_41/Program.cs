// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int size = Input("Введите числа");
int[] array;
array = NewArray(size);
PrintArray(array);
Console.WriteLine($"Количество положительных элементов = {CountPositiveNum(array)}");
//------------------------------------------------

// Вводим число
int Input(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] NewArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Input($"Введите {i + 1} -й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i} = {array[i]}");
    }
}

int CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
        return count;
    }
}