// Сортировка выбором

/*
[6, 15, 2, 9, -3]
min = 6
6 < 15
6 > 2
min = 2
2 < 9
2 > -3
min = -3
[-3, 6, 15, 2, 9]
[6, 15, 2, 9]
min = 6
6 < 15
6 > 2
min = 2
2 < 9
[-3, 2, 6, 15, 9]
min = 6
6 < 15
6 < 9
[-3, 2, 6, 15, 9]
min = 15
15 > 9
[-3, 2, 6, 9, 15]
*/

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
// Заполнение массива 
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
//  Сортировка
for (int i = 0; i < n - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if(array[j] < array[minIndex])
            minIndex = j;
    }
    int temp;
    temp = array[minIndex];
    array[minIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");