Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];
void massive(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(99,999);
}
}
int quan(int[] randomArray)
{
int quan = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
quan = quan + 1;
}
return quan;
}
massive(a);
Console.WriteLine($"Количество чётных чисел в массиве: {quan(randomArray)}");