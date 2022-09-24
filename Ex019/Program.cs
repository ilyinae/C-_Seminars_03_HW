Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
if (num.Length == 5)
    Console.WriteLine(num[0] == num[4] && num[1] == num[3]);
else    
    Console.WriteLine("Ошибка ввода");