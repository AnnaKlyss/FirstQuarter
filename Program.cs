// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Введите набор символов, букв или цифр через пробел: ");
string inputText = Console.ReadLine();
string[] stringArray = inputText.Split(' ');
string[] arr = new string[stringArray.Length];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = stringArray[i];
}

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        count++;
    }
}

string[] arr2 = new string[count];
count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        arr2[count] = arr[i];
        count++;
    }
}
PrintArray(arr2);