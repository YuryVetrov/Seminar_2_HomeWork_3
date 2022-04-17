// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
string number = Console.ReadLine();
int length = number.Length;
if (number.Length <= 1)
    Console.WriteLine("Нет второй цифры");
else
    Console.WriteLine(number[1]);
//if (number < 0)
   // (number = -number);
   // {
   //     Console.WriteLine("введите положительное число");
   // }
//string number = Console.ReadLine();
//Console.WriteLine(number[2]);

//if (number.Length() <= 0)
    ///Console.WriteLine("Число состоит из одного числа, введите трехзначное число");
//else
    //Console.WriteLine(number[2]);

//if (number.Length == 1)
//Console.WriteLine("Нет второй цифры");
        //while (num >= 1000)
        //{
            //num = num / 10;
           // num /=10;
        //}
        //Console.WriteLine(num % 10);