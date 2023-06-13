int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Task41()
{
    // Задача 41: Пользователь вводит с клавиатуры M чисел. 
    // Посчитайте, сколько чисел больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // -1, -7, 567, 89, 223-> 3


    int start = Input("Введите количество чисел, которые необходимо обработать ");
    int count = start;
    int countSize = 0;

    while (count > 0)
    {
        int number = Input("Введите число ");
        if (number > 0)
            countSize++;
        count--;
    }
    Console.WriteLine($"Больше 0 введено {countSize} чисел");

}

void Task43()
{
    // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    // значения b1, k1, b2 и k2 задаются пользователем.
    // Например : b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    int b1 = Input("Введите b1: ");
    int k1 = Input("Введите k1: ");
    int b2 = Input("Введите b2: ");
    int k2 = Input("Введите k2: ");




    Console.WriteLine($"Точки пересечение: ({x}, {y})");

}


Console.Clear();
Task43();