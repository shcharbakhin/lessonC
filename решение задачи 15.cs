{
    int A;
    Console.WriteLine("Введите порядковый номер дня недели");
    A = Convert.ToInt32(Console.ReadLine());
    if (A > 7)
    {
        Console.WriteLine("Вы наверное ошиблись. Такого дня в неделе нет.");
    }
    else
    {
        if (A < 5)
        {
        Console.WriteLine(A);
        Console.Write("этот день не является выходным");
        }

        else
        {
            Console.WriteLine(A);
            Console.Write("этот день является выходным");
        }
    }
}