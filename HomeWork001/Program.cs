Console.WriteLine("Введите первое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int m = Convert.ToInt32(Console.ReadLine());

if (m>n)
Console.WriteLine ("Второе число больше");

else if (m<n)
{
    Console.WriteLine ("Первое число больше");

}
else
{
     Console.WriteLine ("Числа равны");   
}