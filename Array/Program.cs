string[] arr = {"Лето", "Осень", "Лед", "Сад", "Зима", "Ель", "Весна"};
string[] result = new string[arr.Length];


void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void Print(string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i]+" ");
    }
    Console.WriteLine();
}

NewArray(arr, result);
Print(arr);
Console.WriteLine();
Print(result);