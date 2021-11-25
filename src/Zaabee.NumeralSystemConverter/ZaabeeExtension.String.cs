namespace Zaabee.NumeralSystemConverter;

public static partial class ZaabeeExtension
{
    public static int ToInt(this string value, NumeralSystem numeralSystem) =>
        value.ToInt((byte)numeralSystem);

    public static long ToLong(this string value, NumeralSystem numeralSystem) =>
        value.ToLong((byte)numeralSystem);

    public static int ToInt(this string value, byte fromBase)
    {
        if (string.IsNullOrWhiteSpace(value)) return default;

        var isMinus = false;
        if (value[0] is '-')
        {
            isMinus = true;
            value = new string(value.Skip(1).ToArray());
        }

        if (value.Any(c => !char.IsLetterOrDigit(c)))
            throw new ArgumentException("The string can only contain letter or digit.", nameof(value));

        if (fromBase <= 36) value = value.ToLower();

        var result = value
            .Select((t, i) => Consts.LetterAndDigit.IndexOf(t) * (int)Math.Pow(fromBase, value.Length - i - 1))
            .Sum();

        result = isMinus ? 0 - result : result;
        return result;
    }

    public static long ToLong(this string value, byte fromBase)
    {
        if (string.IsNullOrWhiteSpace(value)) return default;

        var isMinus = false;
        if (value[0] is '-')
        {
            isMinus = true;
            value = new string(value.Skip(1).ToArray());
        }

        if (value.Any(c => !char.IsLetterOrDigit(c)))
            throw new ArgumentException("The string can only contain letter or digit.", nameof(value));

        if (fromBase <= 36) value = value.ToLower();

        var result = value
            .Select((t, i) => Consts.LetterAndDigit.IndexOf(t) * (long)Math.Pow(fromBase, value.Length - i - 1))
            .Sum();

        result = isMinus ? 0 - result : result;
        return result;
    }
}