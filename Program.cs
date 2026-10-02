/*string nome = "Marco";
int mesi = 6;
Console.WriteLine(nome);
Console.WriteLine(mesi);
Console.WriteLine($"{nome} ha un piano di {mesi} mesi");*/
//Console.WriteLine("Come ti chiami?");
//string? nome = Console.ReadLine(); //indica che la variabile è una stringa che può essere null
//Console.WriteLine($"Ciao {nome}");
// Target: .NET 8, C# 12, console app
Console.WriteLine("Come ti chiami?");
string? nome = Console.ReadLine();
if (string.IsNullOrWhiteSpace(nome))
{
    Console.WriteLine("Senza nome non faccio la scheda.");
    return;
}
Console.WriteLine("In che città sei?");
string? citta = Console.ReadLine();
if (string.IsNullOrWhiteSpace(citta))
{
    Console.WriteLine("Senza citta' non faccio la scheda.");
    return;
}
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Città: " + citta);