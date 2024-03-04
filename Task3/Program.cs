// // Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// void Main()
// {
//     int arraySize = ReadInt("Введите количество чисел: ");
//     int [] array = GenerateArray(arraySize, 0, 100);
//     System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
//     System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array,array.Length-1))}]");
// }

// int [] ArraySwap(int [] array,int index)
// {

//     if (index <= 0)
//     {
//         return array;
//     }
//     int temp = array[index];
//     array[index] = array[array.Length - index-1];
//     array[array.Length - index-1] = temp;
//     return ArraySwap(array,index -= 2);
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.TiInt32(Console.ReadLine());
// }

// int GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int [size];

//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(leftRange, rightRange + 1);
//     }
//     return array;
// }

// string PrintArray(int [] array)
// {
//     return string.Join(", ",array);
// }

// Main();


void Main()
{
    int[] array = CreateArray(10, 10, 0);
    System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
    System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array, array.Length - 1))}]");
}         
            

int[] CreateArray(int size, int max, int min)
{
    int[] array = new int[size];
    Random rand = new();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
string PrintArray(int[] array)
{
    return string.Join(", ", array);
}
int[] ArraySwap(int[] array, int index)
{

    if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index - 1];
    array[array.Length - index - 1] = temp;
    return ArraySwap(array, index -= 2);
}

Main();


