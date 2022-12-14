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

string[] FillArrayConsole(string[] arr)
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

void FillArrayFromArray (string[] arr, string[] newarr)
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
Console.WriteLine("Введите строки первого массива. После ввода одной строки необходимо нажать клавишу “Enter”:");
firstarray = FillArrayConsole(firstarray);
int count = FindCount(firstarray);
if (count != 0)
{
    string[] secondarray = CreateArray(count);
    FillArrayFromArray(firstarray, secondarray);
    Console.WriteLine(PrintGood(secondarray));
}
else Console.WriteLine ("В первоначальном массиве нет строк длиной менее или равной 3");