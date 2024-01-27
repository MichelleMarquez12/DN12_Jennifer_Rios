// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("\t\tHello, World\n");

string text = " This is an String ";
int age = 35;
DateTime now = DateTime.Now;
double amount = 0;

Console.WriteLine(text);

//concatenación de string's
string string2 = text + " a second string ";
Console.WriteLine("\nThis is a concatenation of string's: " + string2 + " and this an age: " + age);
Console.WriteLine("\nThis is today's date and time: " + now + " and this a date type double: " + amount);
Console.WriteLine("\nTodo unido es: " + text + string2 + age + now + amount);

//otra forma de concatenación de string es con el método format
string string3 = string.Format("\nThe age is a: {0}, The time is: {1}, and the amount is: {2}", age, now, amount);
Console.WriteLine(string3);

//3 forma de concatenación de strings
string string4 = $"\nThe age is a: {age}, The time is: {now}, and the amount is: {amount}";
Console.WriteLine(string4);

//datos char
char sampleChar = 'C';
Console.WriteLine(sampleChar);

char[] arrayChar = string4.ToCharArray();

Console.WriteLine(arrayChar);

/*for (int i =0; i < arrayChar.Length; i++)
{
	Console.WriteLine(arrayChar[i]);
}*/

//operaciones básicas
age = 10 / 3;
Console.WriteLine(age);

amount = (double)10 / (double)3;
Console.WriteLine(amount);

//diferencia de dias entre fechas
DateTime dateTime = new DateTime(2000,1,1);
TimeSpan timeStamp1 = now - dateTime;
Console.WriteLine("Días: " + timeStamp1.TotalDays);
Console.WriteLine("Milisegundos: " + timeStamp1.TotalMilliseconds);
Console.WriteLine("Horas: " + timeStamp1.TotalHours);
Console.WriteLine("Minutos: " + timeStamp1.TotalMinutes);

string test = "15";
//conversion de un string a entero
age = int.Parse( test);

//conversion de un string a booleano
string booleanValue = "True";
bool isTrue = bool.Parse (booleanValue);

Console.ReadKey();