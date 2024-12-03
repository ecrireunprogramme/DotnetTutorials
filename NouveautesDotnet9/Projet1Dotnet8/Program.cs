// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Specialized;

OrderedDictionary orderedDict = new()
{
    { "pomme", 1 },
    { "banane", 2 },
    { "mangue", 3 }
};

orderedDict.Add("papaye", 4);
orderedDict.RemoveAt(0);
orderedDict.RemoveAt(2);
orderedDict.Insert(0, "ananas", 5);

int valeur = (int) orderedDict["ananas"];

foreach (DictionaryEntry entry in orderedDict)
{
    Console.WriteLine($"{entry.Key}, {entry.Value}");
}
