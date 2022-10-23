// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void EnteringNumbers(int[] arr, int length)
{
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
    }
}

void PrintArray(int[] arr1)
{
    for (int i = 0; i <= arr1.Length - 2; i++)
    {
        Console.Write($"{arr1[i]}, ");
    }
    Console.Write($"{arr1[arr1.Length - 1]}");
}

int AmmountOfRequiredNumbers(int[] arr)
{
    int result = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
    return result;
}

Console.WriteLine("Укажите количество чисел, которые Вы планируете ввести: ");
int amountOfNumbers = Convert.ToInt32(Console.ReadLine());
int[] array = new int[amountOfNumbers];
EnteringNumbers(array, amountOfNumbers);
int ammountOfRequiredNumbers = AmmountOfRequiredNumbers(array);
PrintArray(array);
Console.Write($" -> {ammountOfRequiredNumbers}");