
/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

*/

string read_int = "";
bool result = true;

Console.Write("Введите пятизначное число: ");

while(true)
{	
	//Ждем ввода числа
    read_int = Console.ReadLine()!;
	
	//Проверяем число ли ввели
    if( int.TryParse(read_int, out _ ) )
    {
        //Если число пятизначное, выходим из цикла while
        if(read_int.Length == 5 )
        {
            break;
        }
        else
        {
            Console.Write("Число должно быть пятизначным:");
        }
    }
    else
    {
        Console.Write("Введено некорректное число, повторите попытку ввода пятизначного числа:");
    }
    
}

//Циклом проходимся по противоположным символам начиная от краев к центру и проверяем одинаковые ли они.
for(int i=0, k=read_int.Length-1; i <= (read_int.Length/2) - 1; i++, k-- )
{
    /*Если символы разные то result = false и выходим из цикла, нет смысла дальше проверять если уже есть различия.
    А если не попалось ни одного разного символа, то переменная result так и останется true;
    */
    if(read_int[i] != read_int[k])
    {
        result = false;
        break;
    }
}

if(result)   
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Число {read_int} является полиндромом.");
}
else         
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Число {read_int} не является полиндромом.");
}
Console.ResetColor();