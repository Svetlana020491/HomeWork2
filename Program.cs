int InputNumber(string text) // метод для ввода начальной информации 
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());

        }

void Task10()
        {
            // Напишите программу, которая принимает на вход трёхзначное число 
            // и на выходе показывает вторую цифру этого числа.

            int number = InputNumber("Введите трехзначное число ");

            int tens = number / 10 % 10;

            Console.Write($"{number} ");
            Console.WriteLine($"вторая цифра этого числа -> {tens}");
        }

void Task15()
{
        // Задача 15: Напишите программу, которая принимает на вход цифру, 
        //обозначающую день недели, и проверяет, является ли этот день выходным.

int number = InputNumber("Введите число, соответствующее дню недели");
if  (number ==1 |number < 6) 
{
        Console.WriteLine($"Этот день рабочий");
        }
else if (number == 6 || number == 7) 
{
        Console.WriteLine($"Этот день выходной");
        }
else 
{       
        Console.WriteLine($"Данные введены не верно");
}
}

void Task13()
{
//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.


int number = InputNumber("Введите число");
number = Math.Abs(number);
if (number > 99) // если верно, шуруем в цикл
{       
        while(number > 1000) // если число больше 1000 
        {
                number = number / 10; // мы его тут уменьшаем
        }      
        Console.Write($"{number} -> ");
        Console.WriteLine($"Третья цифра равно {number %10}");
}
else // если ИФ ложный
{
        Console.WriteLine($"в этом числе нет 3й цифры");
}

}

void Task10_2() // переворот трехзначного числа 
{        
            // Напишите программу, которая принимает на вход трёхзначное число 
            // и на выходе показывает перевернутую цифру этого числа.

        int number = InputNumber("Введите трехзначное число ");
        //123 
        int result = number % 10 * 100 + number / 10 % 10 * 10 + number / 100;
  
        Console.WriteLine($"{number}-> {result}");
}
Console.Clear();
Task13();
