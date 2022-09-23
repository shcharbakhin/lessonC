{
    int A, B, C, D;
    Console.WriteLine("Введите трехзначное число");
    A = Convert.ToInt32(Console.ReadLine());
    B = A % 10;
    C = (A / 100) * 100;
    if (100 < A && A < 1000)
    {
        D = (A - B - C) / 10;
        Console.Write("Второе цифра числа: ");
        Console.WriteLine(D);
    }
    else
    {
        Console.WriteLine("Вы ввели неправильное число. Запустите программу снова и введите трехзначное число");
    }
}