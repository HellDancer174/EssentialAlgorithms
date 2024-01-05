namespace Numeric;

/// <summary>
/// Линейный конгруэнтный генератор
/// </summary>
public struct RandomNumber
{
    private static int n = 0;
    private static int a = 7;
    private static int b = 5;
    private static int m = 11;


    private readonly int value;

    public RandomNumber()
    {
        var c = (a * n + b);
        value = c % m;
        n = value;
    }

    public int Value => value;

    public override string ToString()
    {
        return $"RandomNumber - {Value}";
    }
}
