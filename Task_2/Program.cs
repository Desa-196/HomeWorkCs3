
/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//Функция принимает отображаемый перед вводом текст, проверяет правильность ввода и возвращает тип double с введенным числом.
double console_read_double(string text)
{
    Console.Write($"{text}: ");
    
    double read_double;

    while(true)
    {
        

        if( double.TryParse(Console.ReadLine(), out read_double ) )
        {
            return read_double;
        }
        else
        {
            Console.Write("Введено некорректное число, повторите попытку ввода:");
        }
        
    }
}

double X1 = console_read_double("Введите координату X первой точки");
double Y1 = console_read_double("Введите координату Y первой точки");
double Z1 = console_read_double("Введите координату Z первой точки");

double X2 = console_read_double("Введите координату X второй точки");
double Y2 = console_read_double("Введите координату Y второй точки");
double Z2 = console_read_double("Введите координату Z второй точки");

double s = Math.Sqrt(Math.Pow(X1-X2, 2) + Math.Pow(Y1-Y2, 2) + Math.Pow(Z1-Z2, 2));

Console.WriteLine($"Расстояние между точками = {Math.Round(s, 2)}");