// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void EnteringNumbers1(int[] arr1, int length1)
{
    for (int i = 0; i < length1; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        arr1[i] = num1;
    }
}

void EnteringNumbers2(int[] arr2, int length2)
{
    for (int i = 0; i < length2; i++)
    {
        Console.WriteLine($"Введите число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        arr2[i] = num2;
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

if (amountOfNumbers > 1)
{
    int[] array = new int[amountOfNumbers];
    EnteringNumbers1(array, amountOfNumbers);
    int ammountOfRequiredNumbers = AmmountOfRequiredNumbers(array);
    PrintArray(array);
    Console.Write($" -> {ammountOfRequiredNumbers}");
}

if (amountOfNumbers == 1)
{
    int[] array = new int[amountOfNumbers];
    EnteringNumbers2(array, amountOfNumbers);
    int ammountOfRequiredNumbers = AmmountOfRequiredNumbers(array);
    PrintArray(array);
    Console.Write($" -> {ammountOfRequiredNumbers}");
}

if (amountOfNumbers < 1) Console.Write("Введено недопустимое значение");