// // Задача 3: Напишите программу, 
// // которая принимает на вход целое число 
// // из отрезка [10, 99] и показывает 
// // наибольшую цифру числа.

 Console.Write("Введите целое число из отрезка [10, 99]: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 10 && number <= 99)
        {
            string numberStr = number.ToString();
            char maxDigit = '0';

            foreach (char digit in numberStr)
            {
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
            }
           Console.WriteLine($"Наибольшая цифра в числе {number} - {maxDigit}");
        }
        else
        {
            Console.WriteLine("Число не соответсвует диапазону");
        }