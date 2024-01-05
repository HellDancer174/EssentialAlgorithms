namespace Numeric;

public struct PeerRandomNumber
{
    private static double n = 1;
    private static double m = 12;


    private readonly int value;

    public PeerRandomNumber(double min, double max)
    {
        var value = min + (n / m) * (max - min);

        if (value >= int.MaxValue)
        {
            n = 1;
            value = min + (n / m) * (max - min);
        }

        n = value;
        this.value = Convert.ToInt32(value);
    }

    public int Value => value;

    public override string ToString()
    {
        return $"PeerRandomNumber - {Value}";
    }
}
