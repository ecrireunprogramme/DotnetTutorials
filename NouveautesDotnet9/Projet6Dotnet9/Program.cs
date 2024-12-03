// See https://aka.ms/new-console-template for more information

using System.Collections;

Concat("Bonjour", "à", "tous");
Concat("Je", "suis", "un", "développeur");
void Concat(params IList<string> items)
{
    for (int i = 0; i < items.Count; i++)
    {
        Console.Write(items[i]);
        Console.Write(" ");
    }
    Console.WriteLine();
}