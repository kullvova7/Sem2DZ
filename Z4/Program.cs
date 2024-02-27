//  Напишите программу, которая на вход принимает натуральное число N, 
//  а на выходе показывает его цифры через запятую.
 
  Console.Write("Введите натуральное число N: ");

        if (Int32.TryParse(Console.ReadLine(), out Int32 n) && n > 0)
        {
            Console.Write("Цифры числа через запятую: ");
            string numberStr = n.ToString();

            for (Int32 i = 0; i < numberStr.Length; i++)
            {
                Console.Write(numberStr[i]);
                if (i < numberStr.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("введите корректное натуральное число.");
        }