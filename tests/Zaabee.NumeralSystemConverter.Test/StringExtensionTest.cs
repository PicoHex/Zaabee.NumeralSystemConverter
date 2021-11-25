using System;
using Xunit;

namespace Zaabee.NumeralSystemConverter.Test;

public class StringExtensionTest
{
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
    public void ToIntTest(int value, NumeralSystem numerationSystem)
    {
        var str = value.ToString(numerationSystem);
        var result = str.ToInt(numerationSystem);
        Assert.Equal(value, result);
        Assert.Equal(0, "".ToInt(numerationSystem));
        Assert.Throws<ArgumentException>(() => "!@#".ToInt(numerationSystem));
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
    public void ToLongTest(long value, NumeralSystem numerationSystem)
    {
        var str = value.ToString(numerationSystem);
        var result = str.ToLong(numerationSystem);
        Assert.Equal(value, result);
        Assert.Equal(0, "".ToLong(numerationSystem));
        Assert.Throws<ArgumentException>(() => "!@#".ToLong(numerationSystem));
    }
}