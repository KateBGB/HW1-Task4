Console.Write("Введите первое число:() ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:() ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:() ");
int c = int.Parse(Console.ReadLine());
int maximal = a;
if(b>a)
{
    maximal = b;
}
else 
{
    if(c>a)
    {

        maximal = c;
    }
    else maximal = a;
}
Console.WriteLine($"Число {maximal} является наибольшим из 3 введенных");