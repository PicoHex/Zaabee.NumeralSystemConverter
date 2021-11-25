using System.Text;

namespace Zaabee.NumeralSystemConverter;

public static partial class ZaabeeExtension
{
    public static string ToString(this long dec, NumeralSystem numerationSystem) =>
        dec.ToString((int) numerationSystem);
        
    public static string ToString(this long dec, int fromBase)
    {
        var stack = new Stack<int>();
        var sb = new StringBuilder();
            
        if (dec < 0)
        {
            sb.Append('-');
            dec = Math.Abs(dec);
        }

        while (dec > 0)
        {
            stack.Push((int)(dec % fromBase));
            dec /= fromBase;
        }

        while (stack.Count > 0) sb.Append(Consts.LetterAndDigit[stack.Pop()]);
        return sb.ToString();
    }
}