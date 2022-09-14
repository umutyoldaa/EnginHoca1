// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 1; i < 10; i+=2)
{ 
    Console.WriteLine("Emre"+i);
}
string[] kurslar = new string[] {"java","python","c#","ruby"};
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}