// See https://aka.ms/new-console-template for more information
using GenericsIntro;

//MyList<int> den = new MyList<int>();
List<string> list = new List<string>();
MyList<string> list2 = new MyList<string>();
list2.Add("Emre");
list2.Add("ahmet");
list2.Add("yuhnnus");
list2.Add("Emre");
Console.WriteLine(list2.Count);
list2.Listele();