//     Задание 1   Вход = трехзначное число, выход - показывает вторую цифру этого числа

// void Test(int num)
// {
//     if (num>99 & num<1000)
//     {
//     int hun = num / 100;
//     int dec = num / 10;
//     int ed = num % 10;
//     Console.WriteLine($"Вторая цифра этого числа: {dec % 10}");
//        }
//     else 
//     {
//         Console.WriteLine("Ошибка. Введите трехзначное число: ");
//     }
// }
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Test(num);

//          задание 2  Вход - заданное число, выход - третья цифра заданного числа, или сообщение что третьей цифры нет

void Test(int num)
{
    while (num > 999)
        {
           num = num / 10;
        }   
        if (num > 100 & num < 999)
        {
            Console.WriteLine($"Третья цифра этого числа: {num % 10}");
        }     
        if (num <100)
        {
            Console.WriteLine("Третьей цифры нет");
        }              
}
Console.WriteLine("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());
Test(num);

//             Задание 3 - вход - цифра обозначает день недели,и проверяет, является ли этот день выходным
// void Test(int num)
// {
//     if (num == 6 || num == 7)
//     {
//         Console.WriteLine("Это выходной!");
//     }
//     else if (num >= 1 & num < 6)
//     {
//         Console.WriteLine("День не является выходным");
//     }
//     else
//     {
//         Console.WriteLine("Ошибка ввода. Введите число от 1 до 7");
//     }
// }
// Console.WriteLine("Введите число от 1 до 7: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Test(num);
