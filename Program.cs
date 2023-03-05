// Написать программу, которая из имеющигося массива строк формирует массив из строк, длина которых меньше либо
// равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

int getDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string[] getArray(int n)
{
    string[] array = new string[n];
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("Введите массив:");
    Console.ResetColor();
    for (int i = 0; i < n; i++)
    {
        Console.Write($"array[{i}] = ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void printArray(string[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("Итоговый массив : [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ResetColor();
}

int getLengthNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
        if (str.Length <= 3)
        {
            count = count + 1;
        }
    }
    return count;
}

string[] getNewArray(string[] array, int count)
{
    string[] newArray = new string[count];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
        if (str.Length <= 3)
        {
            newArray[temp] = array[i];
            temp = temp + 1;
        }
    }
    return newArray;
}

int n = getDataFromUser("Введите количество элементов массива:");
string[] array = getArray(n);
int count = getLengthNewArray(array);
string[] newArray = getNewArray(array, count);
printArray(newArray);