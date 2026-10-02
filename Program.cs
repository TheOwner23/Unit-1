/*string nome = "Marco";
int mesi = 6;
Console.WriteLine(nome);
Console.WriteLine(mesi);
Console.WriteLine($"{nome} ha un piano di {mesi} mesi");*/
Console.WriteLine("Come ti chiami?");
string? nome = Console.ReadLine(); //indica che la variabile è una stringa che può essere null
Console.WriteLine($"Ciao {nome}");