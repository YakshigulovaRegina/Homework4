Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
double c = 1;

for (int i = 0; i < b; i++)
{
    c = Math.Pow(a,b);
}

Console.WriteLine("A^B=" + c);
