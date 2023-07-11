// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] mas = new int[15];

void FillArray(int[] mas)
{
    int lenght = mas.Length;
    int index = 0;
    while (index < lenght)
    {
        mas[index] = new Random (). Next (-100, 1000);
        index++;
    }
}

void PrintArray(int[] mas)
{
    int count = mas.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write (mas[i] + " ");
        i ++;
    }
}
FillArray (mas);
PrintArray (mas);

int count = 0;
int i = 0;

while (i < mas.Length)
{
    if (mas[i] > 0)
    {
    count = count + 1;
    }
    i++;
}
Console.WriteLine();
Console.WriteLine(count);