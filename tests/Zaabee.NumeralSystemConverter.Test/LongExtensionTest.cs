using Xunit;

namespace Zaabee.NumeralSystemConverter.Test;

public class LongExtensionTest
{
    [Theory]
    [InlineData(long.MaxValue, 32)]
    [InlineData(long.MaxValue, 36)]
    [InlineData(long.MaxValue, 62)]
    [InlineData(long.MinValue + 1, 32)]
    [InlineData(long.MinValue + 1, 36)]
    [InlineData(long.MinValue + 1, 62)]
    public void Test(long value, byte radix)
    {
        var str = value.ToString(radix);
        var result = str.ToLong(radix);
        Assert.Equal(value, result);
    }

    [Theory]
    [InlineData(long.MaxValue, NumeralSystem.Binary)]
    [InlineData(long.MaxValue, NumeralSystem.Decimalism)]
    [InlineData(long.MaxValue, NumeralSystem.Duotricemary)]
    [InlineData(long.MaxValue, NumeralSystem.Hexadecimal)]
    [InlineData(long.MaxValue, NumeralSystem.Octal)]
    [InlineData(long.MaxValue, NumeralSystem.SixtyTwoAry)]
    [InlineData(long.MaxValue, NumeralSystem.ThirtySixAry)]
    [InlineData(long.MinValue + 1, NumeralSystem.Binary)]
    [InlineData(long.MinValue + 1, NumeralSystem.Decimalism)]
    [InlineData(long.MinValue + 1, NumeralSystem.Duotricemary)]
    [InlineData(long.MinValue + 1, NumeralSystem.Hexadecimal)]
    [InlineData(long.MinValue + 1, NumeralSystem.Octal)]
    [InlineData(long.MinValue + 1, NumeralSystem.SixtyTwoAry)]
    [InlineData(long.MinValue + 1, NumeralSystem.ThirtySixAry)]
    public void TestByNumerationSystem(long value, NumeralSystem numerationSystem)
    {
        var str = value.ToString(numerationSystem);
        var result = str.ToLong(numerationSystem);
        Assert.Equal(value, result);
    }
}