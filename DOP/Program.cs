﻿/*
В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, причем кусты высажены только по окружности. 
Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов.

Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод – на i-ом кусте выросло ai ягод.

В этом фермерском хозяйстве внедрена система автоматического сбора черники. Эта система состоит из управляющего модуля и нескольких собирающих модулей. 
Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.

Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, 
находясь перед некоторым кустом заданной во входном файле грядки.

Входные данные
Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000) – количество кустов черники. 
Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – число ягод черники, растущее на соответствующем кусте. Все ai не превосходят 1000.

Выходные данные
В выходной файл OUTPUT.TXT выведите ответ на задачу.
*/
int N;
int max = 0;

int console_read_int(string text, int min, int max)
{
    int N;

    Console.Write($"{text}: ");

    while(true)
    {	
        //Проверяем число ли ввели
        if( int.TryParse(Console.ReadLine(), out N ) )
        {
            //Если число пятизначное, выходим из цикла while
            if(N >= min && N <= max)
            {
                break;
            }
            else
            {
                Console.Write($"Число должно быть от {min} до {max} включительно, повторите ввод:");
            }
        }
        else
        {
            Console.Write("Введено некорректное число, повторите попытку ввода числа:");
        }
    }
    return N;
    
}

/*
Функция зацикливает индекс, если переданный индекс находится за пределами массива
то мы лишнее опять отсчитываем с начала массива
*/
int get_index(int index, int N)
{
    if(index >= N)
    {
        index = index - N;
    }
    return index;
}

//Ввод кол-ва кустов
N = console_read_int("Введите количество кустов черники от 3 до 1000 включительно", 3, 1000);

//Создаем массив размером равным кол-ву кустов
int[] array_count_berries = new int[N];
//В цикле заполняем его из консоли
for(int i=0; i < N; i++)
{
    array_count_berries[i] = console_read_int($"Введите кол-во ягод на {i+1} кусте", 0, 1000);
}

for(int i=0; i < N; i++)
{
    /*Суммируем кол-во ягод на трёх кустах, если кусты оказываются за пределами индекса, функция get_index вернёт на сколько мы проли за конец массива
    что позволит нам двигаться как бы по кругу, после конца массива опять в начало*/
    int sum = array_count_berries[i] + array_count_berries[ get_index(i+1, N) ] + array_count_berries[get_index(i+2, N)];
    //Если получили значение больше чем в максимуме, перезаписываем его.
    if(max < sum) max = sum;
}

Console.WriteLine($"Максимальное число ягод, которое может собрать за один заход собирающий модуль = {max}");
