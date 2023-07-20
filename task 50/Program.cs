Console.Write("Введите строку: ");
int s1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int s2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] mas = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
{
    mas[i, j] = random.Next(10, 99);
Console.Write("{0} ", mas[i, j]);
}
Console.WriteLine();
}
    if (s1 < 0 | s1 > mas.GetLength(0) - 1 | s2 < 0 | s2 > mas.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", mas[s1, s2]);
}
Console.ReadLine();