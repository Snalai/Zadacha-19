// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 10000 && num < 100000)
{
    int[] number = new int[5];
    int i = 0;
    int l = number.Length;
    while (num != 0)
    {
        if (num != 0)
        {
            int n = num % 10;
            number[i] = n;
            //y = y * 10;
            num = num / 10;
            i++;
        }
        else
        {
            number[i] = num;
        }
    }
    i = 0;
    while (i <= l - 1)
    {
        if (number[i] == number[l - 1])
        {
            i++;
            l = l - 1;
            if (i == 3)
            {
                Console.WriteLine("Число палиндром");
            }
        }
        else if (number[i] != number[l - 1])
        {
            Console.WriteLine("Число не палиндром");
            break;
        }
    }
}
else
{
    Console.WriteLine("Введите пятизначное число!!!");
}

