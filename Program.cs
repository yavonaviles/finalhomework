/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/
// final task

void ArrayOfStrins(string[] Array)
{
    string[] NewArray = new string[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            NewArray[i] = Array[i];
            Console.Write($"{NewArray[i]} ");
        }
    }
    Console.WriteLine();
}
void PrintArrayOfStrings(string[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write($"{Arr[i]}, ");
    }
    Console.Write($" -> ");
}

string[] MyArray = {"1", "11", "111", "1111", "привет"};
PrintArrayOfStrings(MyArray);
ArrayOfStrins(MyArray);
