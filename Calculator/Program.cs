Console.WriteLine("Выберите действие: ");
Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");

int i = 0;
while (i <=8)
{   
    Console.WriteLine("Выберите действие: ");
    int count = Convert.ToInt32(Console.ReadLine());
    i = count;
    {
        if (count == 1)
        {
            Console.WriteLine("Введите превое число: ");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int two = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(one + two); 
        }
        else if (count == 2)
        {
            Console.WriteLine("Введите превое число: ");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(one - two); 
        }
        else if (count == 3)
        {
            Console.WriteLine("Введите превое число: ");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(one * two); 
        }
        else if (count == 4)
        {
            Console.WriteLine("Введите превое число: ");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(one / two); 
        }
        else if (count == 5)
        {
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень в которую нужно возвести число: ");
            int three = Convert.ToInt32(Console.ReadLine());
            for (int b = 1; b < three; b++) ;
            a <<= 1;
            Console.WriteLine(a);
        }
        else if (count == 6)
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a/100);
        }
        else if (count == 7)
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(System.Math.Round((double)(a/ 100)));
        }
        else if (count == 8)
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;

            for(int с = 2; с <= a; с++)
            {
                b = b * с;
            } 
            Console.WriteLine(b);
        }
    }
} 


