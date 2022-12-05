Console.Write("Введи число: ");
int num = int.Parse(Console.ReadLine());
if (num / 100 <= 0){
    Console.WriteLine("-> третьей цифры нет");
}
int res = (num - (num / 100) * 100) % 10 ;
Console.WriteLine("третья цифра -> " + res);