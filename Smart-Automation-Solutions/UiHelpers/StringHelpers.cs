using System.Text;

namespace UiHelpers;
public static class StringHelpers
{

    public static string StringConcatenation(params string[] values)
    {
        StringBuilder stringBuilder = new();
        foreach (string value in values)
        {
            stringBuilder.Append(value);
            stringBuilder.Append(' ');
        }

        return stringBuilder.ToString();
    }

    public static string StringConcatenation(params object[] values)
    {
        StringBuilder stringBuilder = new();
        foreach (string value in values)
        {
            stringBuilder.Append(value);
            stringBuilder.Append(' ');
        }

        return stringBuilder.ToString();
    }
}