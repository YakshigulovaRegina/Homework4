//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
string a = Console.ReadLine();
char[] array = a.ToCharArray();
int sum = addition(array);
Console.WriteLine("Сумма цифр = " + sum);


int addition(char [] array)
{
    int length = array.Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        int c = int.Parse(array[i].ToString());
        result = result + c;
    }
    return result;
}


