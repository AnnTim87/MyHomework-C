// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int value = 39467;
int x = value % 10;
Console.WriteLine(value);
if (value <=99)
{
    Console.WriteLine("Третьей цифры нет"); 
}
else
{
    while (value > 999)

    {
     value = value/10; 
     x = value % 10;  
    }
Console.WriteLine(x);
}