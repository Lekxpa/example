// Задача: Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, либо равна 
//3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении 
//не рекомендуется пользоваться коллекциями, лучше обойтись 
//исключительно массивами

// Примеры:
// [“hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] MyArray (int Array)
{
    string[] NArray = new string[Array];
    for (int i = 0; i < Array; i++)
    {
        Console.Write($"Введите {i+1} значение : ");
        NArray[i] = Console.ReadLine();
    }
    return NArray;
}

void PrintArray(string[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

string[] CalculationOfSymbol(string[] COSArray)
{
    string[] NewArray = new string[COSArray.Length];
    int Length = 3;
    int SizeArray = 0;
    for (int j = 0; j < COSArray.Length; j++)
    {
        if (COSArray[j].Length <= Length)   
        {
            NewArray[SizeArray] = COSArray[j];
            SizeArray++;
        }
    }
   return NewArray;
}    

Console.Write("Введите количество значений в массиве: ");
int values = int.Parse(Console.ReadLine());
string[] MonArray = MyArray(values);
Console.Write("Исходный массив: ");
PrintArray(MonArray);

string[] NewArr = CalculationOfSymbol(MonArray);
Console.Write("Итоговый массив: ");
PrintArray(NewArr);