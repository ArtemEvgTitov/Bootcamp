// Сортировка подсчётом
// Работает только и цифрами

int[] array = { 0, 2, 3, 2, 1, 5, 9, 1, 1 };
int[] array2 = { 0, 2, 3, 2, 20, 5, 9, 10, 1 };
int[] sortedArray = CountingSortExtended(array2);
CountingSort(array);
Console.WriteLine(string.Join(", ", sortedArray));


void CountingSort(int[] inputArray)
{
    int[] counters = new int[10]; // массив повторений
    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
        // int ourNumber = inputArray[i];
        // counters[ourNumber]++;
    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i;
            index++;
        }
    }
}

int[] CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    
    int[] sortedArray = new int[inputArray.Length];
    int[] counters = new int[max + 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[index] = i;
            index++;
        }
    }
    return sortedArray;
}