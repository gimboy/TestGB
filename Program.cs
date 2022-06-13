/*
Написать программу, которая из имеющегося 
массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно внести с клавиатуры,
либо задать на старте выполнения алгоритма.
*/
Console.WriteLine("Введите ваш массив и при завершении напишите выход");
string[] array = new string[100];
bool hasNext = true;

FillArray(array);
string[] newArrayS = DelLessTreeCharacters(array);
ShowArray(newArrayS);

string[] FillArray(string[] array)
{
    int i = 0;
    while (hasNext)
    {
        array[i] = Console.ReadLine();
        if (array[i].Equals("выход")) hasNext = false;
        i++;
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] DelLessTreeCharacters(string[] array)
{
    string[] newArray = new string[array.Length];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null && array[i].Length < 4)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}