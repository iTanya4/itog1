
string [] array = {"2022", "22", "Sheremetevo", "SVO", "Vnukovo", "VKO", "Domodedovo", "DME"};
Console.WriteLine("Исходный массив:");

void PrintArray(string [] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}  ");
    Console.WriteLine();
}

PrintArray(array);
Console.WriteLine(); 

void FoundArray (string [] firstarray)
{
     int size = firstarray.Length;
     string [] newarray = new string [size];
     for (int j = 0; j < size; j++)
     {      
        if (firstarray[j].Length <= 3)
        {
            newarray[j] = firstarray[j];
            Console.Write($"{newarray[j]}  "); 
        }
     }
}
Console.WriteLine("Новый массив:");
FoundArray(array);
Console.WriteLine();
