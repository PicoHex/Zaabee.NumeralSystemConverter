using Xunit;

namespace Zaabee.NumeralSystemConverter.Test;

public class IntExtensionTest
{
    [Theory]
    [InlineData(int.MaxValue, 32)]
    [InlineData(int.MaxValue, 36)]
    [InlineData(int.MaxValue, 62)]
    [InlineData(int.MinValue + 1, 32)]
    [InlineData(int.MinValue + 1, 36)]
    [InlineData(int.MinValue + 1, 62)]
    public void Test(int value, byte radix)
    {
        var str = value.ToString(radix);
        var result = str.ToInt(radix);
        Assert.Equal(value, result);
    }

    [Theory]
    [InlineData(int.MaxValue, NumeralSystem.Binary)]
    [InlineData(int.MaxValue, NumeralSystem.Decimalism)]
    [InlineData(int.MaxValue, NumeralSystem.Duotricemary)]
    [InlineData(int.MaxValue, NumeralSystem.Hexadecimal)]
    [InlineData(int.MaxValue, NumeralSystem.Octal)]
    [InlineData(int.MaxValue, NumeralSystem.SixtyTwoAry)]
    [InlineData(int.MaxValue, NumeralSystem.ThirtySixAry)]
    [InlineData(int.MinValue + 1, NumeralSystem.Binary)]
    [InlineData(int.MinValue + 1, NumeralSystem.Decimalism)]
    [InlineData(int.MinValue + 1, NumeralSystem.Duotricemary)]
    [InlineData(int.MinValue + 1, NumeralSystem.Hexadecimal)]
    [InlineData(int.MinValue + 1, NumeralSystem.Octal)]
    [InlineData(int.MinValue + 1, NumeralSystem.SixtyTwoAry)]
    [InlineData(int.MinValue + 1, NumeralSystem.ThirtySixAry)]
    public void TestByNumerationSystem(int value, NumeralSystem numerationSystem)
    {
        var str = value.ToString(numerationSystem);
        var result = str.ToInt(numerationSystem);
        Assert.Equal(value, result);
    }
}