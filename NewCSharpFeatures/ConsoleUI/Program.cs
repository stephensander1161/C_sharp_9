using ConsoleUI;
using System;
      
Console.WriteLine("Hello World!");
Console.WriteLine(Add(4, 3));

PersonModel p = new PersonModel { Id = 1, FirstName = "Stephen", LastName = "Sander" };
//same as 
PersonModel p0 = new() { Id = 1, FirstName = "Stephen", LastName = "Sander" };

PersonModel p2 = new PersonModel();
//same as 
PersonModel p3 = new(2, "sue", "storm");

//p.Id = 2
p.FirstName = "Stephanus";

Console.WriteLine($"hello {p.FirstName} {p.LastName} ({p.Id})");


if (p2 != null)
{
    Console.WriteLine("old way")
}
//same as
if (p2 is not null)
{
    Console.WriteLine("not is a new pattern");
}
        
static double Add(double x, double y)
{
return x + y;
}

//top level calls must go on top. Must only have in one class. 



