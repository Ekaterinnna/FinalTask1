int GetNumber(string text)
   {
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
   }

string[] CreateArray(int count)
{
    return new string[count];
}

string[] FullArrayConsole(string[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

int FindCount(string[] array)
{
    int c = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) c++;
    return c;
}

void FullArrayFromArray (string[] arr, string[] newarr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) 
        {
            newarr[j] = arr[i];
            j++;
        }
    }
}

string PrintGood(string[] array)
{
  int size = array.Length;
  int i = 0;
  string result = "[ ";

  while (i < size)
  {
    result += ($"{array[i]} ");
    i++;
  }
  return result + "]";
}

int n = GetNumber("Введите значение длины первой строки n = ");
string[] firstarray = CreateArray(n);
Console.WriteLine("Введите строки первого массива:");
firstarray = FullArrayConsole(firstarray);
int count = FindCount(firstarray);
string[] secondarray = CreateArray(count);
FullArrayFromArray(firstarray, secondarray);
Console.WriteLine(PrintGood(secondarray));