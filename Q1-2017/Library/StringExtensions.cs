using System.Globalization;
using System.Threading;

namespace Library
{
    public static class StringExtensions
    {
        public static string ConvertToTitleCase(this string source)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(source);
        }
    }
}
