// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(new Person("Jacob", "Liou"));

Person person = new("Jacob", "Liou");
Console.WriteLine(person);

// Measurement measurement = new Measurement(5.0d, "");
// // measurement.Description = "";
// // measurement.Value = 5.0d;
// Console.WriteLine(measurement);

var newM = default(Measurement);
Console.WriteLine(newM);

var demo = default(Demo);
Console.WriteLine(demo == null);
Console.WriteLine(demo?.MyProperty);
Console.Write($"{demo?.MyProperty}");
var @for = 1;
Console.WriteLine(@for);

var n = default(int);
Console.WriteLine(n);

var nl = default(int?);
Console.WriteLine(nl);
