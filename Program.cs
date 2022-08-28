
/*
// напишите программу которая выводит случайное число из отрезка (10,99) и показывает наибольшую цыфру....

int FindBiggestDigit(int number)
{
    int ed = number % 10;
    int des = number / 10;
    int max;

    if (ed > des)
        max = ed;
    else
        max = des;
    return max;
}

int RandomNumber = new Random().Next(10,100);

int BigestDigit = FindBiggestDigit(RandomNumber);
Console.WriteLine($"Bigger digit of {RandomNumber} is {BigestDigit}");



//Задача. напишите программу которая выводит случайное 3-хзначное число и удаляет вторую цыфру этого числа


int RandomNumber = new Random().Next(100,1000);
int CutNumber(int number)
{
int ed = number % 10;
int sot = number / 100;

return  sot*10 + ed;
}
int newNumber = CutNumber(RandomNumber);

Console.WriteLine($"new version {RandomNumber} is {newNumber}");



//задача напишите программу которая будет принимать на вход 2 числа и выводить является ли второе число кратное первому

void IsDivisionable( int num1, int num2)
{
    int Reminder = num2 % num1;
if (Reminder == 0)
{
    Console.WriteLine($"{num2} is Divisionable of {num1}. ");
}
else
{
    Console.WriteLine($"{num2} is not Divisionable of {num1}.Reminder is {Reminder} ");
}
}

Console.Write( "input first number: " );
int n1 = Convert.ToInt32(Console.ReadLine());
 Console.Write( "input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

IsDivisionable(n1, n2);


*/

// задача задача напишите программу которая будет принимать на вход число и проверять одновременно кратно ли оно 7 и 23.

bool IsDivis(int number)
{
if (number % 7 == 0 && number % 23 == 0)
return true;
else
return false;
}

Console.Write( "input number: " );
int n = Convert.ToInt32(Console.ReadLine());

bool IsDivision = IsDivis(n);
Console.WriteLine(IsDivision);

