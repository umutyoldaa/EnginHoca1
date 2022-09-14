// See https://aka.ms/new-console-template for more information
using ClassIntro;

Console.WriteLine("Hello, World!");
Kurs Kurs1 = new Kurs();
Kurs Kurs2 = new Kurs();
Kurs Kurs3 = new Kurs();
Kurs Kur4 = new Kurs();

Kurs1.NameSet = "Emre";
Kurs2.NameSet = "beray";
Kurs3.NameSet = "merve";
Kurs[] kurslar=new Kurs[]{Kurs1,Kurs3,Kurs2, Kur4};
foreach (var item in kurslar)
{
    Console.WriteLine(item.NameSet);
}