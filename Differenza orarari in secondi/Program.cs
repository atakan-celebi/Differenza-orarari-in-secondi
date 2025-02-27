// See https://aka.ms/new-console-template for more information
Console.WriteLine("inserisci il primo orario in: ore/minuti/secondi");
//dati 1
int o1 = int.Parse(Console.ReadLine());
int m1 = int.Parse(Console.ReadLine());
int s1 = int.Parse(Console.ReadLine());
//dati 2
Console.WriteLine("inserisci il secondo orario in: ore/minuti/secondi");
int o2 = int.Parse(Console.ReadLine());
int m2 = int.Parse(Console.ReadLine());
int s2 = int.Parse(Console.ReadLine());
// dati 3
int differenza = ((o1 * 3600) + (m1 * 60) + s1) - ((o2 * 3600) + (m2 * 60) + s2);
if (differenza < 0)
{
    differenza = differenza * -1;
}
Console.WriteLine("la differenza in secondi dei due orari è: {0}",differenza);