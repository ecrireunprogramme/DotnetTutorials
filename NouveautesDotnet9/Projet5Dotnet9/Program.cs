// See https://aka.ms/new-console-template for more information

IEnumerable<string> lines2 = File.ReadAllLines("output.txt");

foreach ((int index, string line) in lines2.Index())
{
    Console.WriteLine($"Line number: {index + 1}, Line: {line}");
}