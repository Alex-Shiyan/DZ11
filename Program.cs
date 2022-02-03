//
// Домашнее задание к занятию 11. Структуры.
//
// Задача 1. Разработать структуру для решения линейного уравнения 0=kx+b. 
// Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
// Для решения уравнения предусмотреть метод Root. 
// Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.
//

using DZ11;
// Задаем коэффициент уравнеия k
double k;
Console.Write("Введите коэффициент k= ");
while (!double.TryParse(Console.ReadLine(), out k))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}
// Задаем коэффициент уравнеия b
double b;
Console.Write("Введите коэффициент b= ");
while (!double.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}
Console.WriteLine();
// Создаем экзепляр uravnenie струтуры Uravnenie
Uravnenie uravnenie = new Uravnenie(k, b);
// Вызываем метод Root и выводим строку на экран 
Console.WriteLine(uravnenie.Root());
Console.ReadKey();