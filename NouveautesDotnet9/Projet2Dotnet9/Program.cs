// See https://aka.ms/new-console-template for more information

using System.Collections.ObjectModel;

var mySet = new ReadOnlySet<int>(new HashSet<int> { 1, 2, 3 });

foreach (var value in mySet)
{
    Console.WriteLine(value);
}