Console.WriteLine("Введите первое число! ");
int n = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите второе число! ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число! ");
int k = Convert.ToInt32(Console.ReadLine());

if (n>m)
{
    if (n>k)
    {
        Console.WriteLine("Первое - максимальное");
    }
    else if (n==k)
    {
        Console.WriteLine("Первое и третье равны и максимальны");
    }
}
else if (n==m)
{
    if (n>k)
    {
        Console.WriteLine("Первое и второе равны и максимальны");
    }
    else if (n==k)
    {
        Console.WriteLine("Все числа равны");
    }
}
else
{
    if (m>k)
    {
        Console.WriteLine("Второе - максимальное");
    }
    else if (m==k)
    {
        Console.WriteLine("Второе и третье равны и максимальны");
    }
    else
    {
         Console.WriteLine("Третье максимальное");       
    }
}

