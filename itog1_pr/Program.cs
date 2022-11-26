
string [] array = {"2022", "22", "Sheremetevo", "SVO", "Vnukovo", "VKO", "Domodedovo", "DME"};
Console.WriteLine("Исходный массив:");
int n =3;
void PrintArray(string [] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]}  ");
    Console.WriteLine();
}

PrintArray(array);
Console.WriteLine(); 

int size = 0;
int count = 1;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            size = count;
            count++;
        }
    }

string [] newArray = new string [size];
void FoundArray (string [] firstArray, string [] newArray)
{
     
     int k=0;
     for (int j = 0; j < firstArray.Length; j++)
     {      
        if (firstArray[j].Length <= n)
        {
            newArray[k] = firstArray[j];
            k++;
             
        }
     }
}
Console.WriteLine("Новый массив:");
FoundArray(array, newArray);
PrintArray(newArray);
Console.WriteLine();