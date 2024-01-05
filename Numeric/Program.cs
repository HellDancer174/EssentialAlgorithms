// See https://aka.ms/new-console-template for more information
using Numeric;

Console.WriteLine("Hello, World!");
PrintNext(() => new PeerRandomNumber(1, 20));



static void PrintNext<T>(Func<T> valueFunctor)
{
    Console.WriteLine(valueFunctor());
    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.Escape) return;
    PrintNext(valueFunctor);
}
