Random random = new Random();
int[,] mas = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = random.Next(1, 10);
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(mas.GetLength(0));
for (int j = 0; j < mas.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        sum += mas[i, j];
    }
    Console.Write($"{ sum / mas.GetLength(0)} ");
}
Console.ReadLine();