﻿// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

 Console.Write("Введите координату X: ");
 double x = double.Parse(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = double.Parse(Console.ReadLine());

        int quadrant = 0;

        if (x > 0 && y > 0)
            quadrant = 1;
        else if (x < 0 && y > 0)
            quadrant = 2;
        else if (x < 0 && y < 0)
            quadrant = 3;
        else
            quadrant = 4;

        Console.WriteLine($"Точка ({x}, {y}) находится в {quadrant} четверти.");