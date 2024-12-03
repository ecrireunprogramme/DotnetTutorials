// See https://aka.ms/new-console-template for more information

Concat("Bonjour", "à", "tous");
Concat("Je", "suis", "un", "développeur");
void Concat(params string[] items)
{
    for (int i = 0; i < items.Length; i++)
    {
        Console.Write(items[i]);
        Console.Write(" ");
    }
    Console.WriteLine();
}