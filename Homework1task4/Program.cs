int i = 1;
int N;

Console.WriteLine("Введите число:");
    N = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Чётные числа от 1 до " + N);
        while (i <= N)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                i++;
            }
