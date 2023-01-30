// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Укажите количество вводимых чисел: ");
int x = Convert.ToInt32(Console.ReadLine());
int pos = 0;

int PrintNums(int x, int pos)
{
    for (int i=1; i<=x; i++)
    {
        Console.Write($"Введите число {i}: ");
        int y = Convert.ToInt16(Console.ReadLine());
        if(y>0) 
        {
            pos+=1;
        }
    }

    Console.WriteLine($"Количество введенных положительных чисел равно {pos}");
    return pos;
}

PrintNums(x, pos);
