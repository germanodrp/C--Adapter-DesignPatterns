
using AdapterAPP;

IAparelho a = new Tela();
Console.WriteLine(a.On());
Console.WriteLine(a.Off());
Console.WriteLine();
a = new Computador();
Console.WriteLine(a.On());
Console.ReadKey();