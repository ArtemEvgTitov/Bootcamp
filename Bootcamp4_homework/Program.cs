/* Дана последовательность из N целых чисел и число K. 
Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, 
если K – положительное и влево, если отрицательное.*/

int[] Shift(int[] array)
{
    Console.Write("Введите число К: ");
    int K = Convert.ToInt32(Console.ReadLine());
    int size = array.Length;
    int[] array2 = new int[size];
    if (K > 0)
    {
        for (int i = 0; i < size; i++)
        {
            if (i + K < size)
                array2[i + K] = array[i];
            if (i + K >= size)
                array2[i + K - size] = array[i];
        }
    }
    if (K < 0)
    {
        for (int i = size - 1; i >= 0; i--)
        {
            if (i + K > 0)
                array2[i + K] = array[i];
            if (i + K <= 0)
                array2[i + K] = array[i];
        }
    }
    return array2;
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] newArray = Shift(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Конечный массив: [" + string.Join(", ", newArray) + "]");
