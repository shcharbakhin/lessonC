
{
    int count = 7;
    int[] array = new int[count];
    int index = 0;
    int sum = 0;
    int B;
    Console.WriteLine("Массив: ");

    while (index < count)
    {
        array[index] = new Random().Next(1, 101);
        Console.WriteLine(array[index] + " ");
        index += 1;
    }
    index = 0;
    while (index < count)
    {
        index += 1;
    }
    index = 0;
    while (index < count)
    {
        if (array[index] > 0)
            sum += array[index];
        index++;
    }
    Console.Write("сумма элементов массива: ");
    Console.WriteLine(sum);
    B = sum / count;
    Console.WriteLine("среднее арифметическое");
    Console.WriteLine(B);
    Console.WriteLine("end");
}