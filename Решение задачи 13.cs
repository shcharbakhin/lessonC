{
    int A, B, C;
    Console.WriteLine("Введите число");
    A = Convert.ToInt32(Console.ReadLine());
    C = (A / 1000) * 1000;
    if (A < 100)
    {
        Console.WriteLine("В числе нет третье цифры");
    }
    else
    {
        B = (A - C) / 100;
        Console.Write("Третья цифра числа: ");
        Console.WriteLine(B);
    }
}