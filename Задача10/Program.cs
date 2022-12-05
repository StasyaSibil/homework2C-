Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int res = (num - (num / 100) * 100) / 10 ;
Console.WriteLine("вторая цифра этого числа: "+ res);