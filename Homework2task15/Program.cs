// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if (number > 5)
{
   Console.WriteLine("(этот день выходной) -> да"); 
}
else 
{
    Console.WriteLine("(этот день выходной) -> нет");
}