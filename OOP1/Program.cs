// See https://aka.ms/new-console-template for more information
using OOP1;

Console.WriteLine("Hello, World!");

Product product2 = new Product { CategoryId=5,Id=1,ProductName="Kalem",UnitPrice=15,UnitInStock=100};
Console.WriteLine( product2.ProductName ); 
ProductManager product3 = new ProductManager();
product3.Add(product2);
