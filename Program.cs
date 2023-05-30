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
if  (number ==1 |number < 6) Console.WriteLine($"Этот день рабочий");
else if (number == 6 || number == 7) Console.WriteLine($"Этот день выходной");
else Console.WriteLine($"Данные введены не верно");

}


//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

// 78 -> третьей цифры нет
// 3267432979 -> 6



int number = InputNumber("Введите число");
if (number > 999 ) 
 {while (number > 999 )
  {  number = number /10;}  Console.WriteLine($"{number % 10}");} //если number > 999,
  // надо number = number /10, и никак не получается
else if (number < 99) Console.WriteLine($"в этом числе нет 3й цифры");
// 3 семинар еще не смотрела 


    

