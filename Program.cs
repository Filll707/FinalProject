/* 
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. 
*/

void print_array(string[] new_array_for_print)
{
    Console.Write("[");
    for (int i = 0; i < new_array_for_print.Length - 1; i++)
    {
        Console.Write($"{new_array_for_print[i]}, ");
    }
    Console.Write($"{new_array_for_print[new_array_for_print.Length - 1]}");
    Console.Write("]");
}
string[] stringArray = { "12", "258", "Sunday", "mo", "for", "rurur" };
int newStringArrayLength = 0;
for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
    {
        newStringArrayLength += 1;
    }
}
string[] shortStringArray = new string[newStringArrayLength];
int count = 0;
for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
    {
        for (int j = 0 + count; j < shortStringArray.Length; j++)
        {
            shortStringArray[j] = stringArray[i];
        }
        count += 1;
    }
}
print_array(stringArray);
Console.Write($" -> ");
print_array(shortStringArray);