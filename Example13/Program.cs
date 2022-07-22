/*
645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write("Введите число ");
int n1 = Convert.ToInt32(Console.ReadLine());

while(n1 < 99) 
{
    Console.WriteLine("третьей цифры нет");
    return;
}
    
while (n1 > 999)
{
    n1 = n1 / 10;
}
int result = n1 % 10;

Console.Write(result);
