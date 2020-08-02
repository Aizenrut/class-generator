using System.Linq;

namespace Core.Extensions
{
    public static class StringExtensions
    {
        public static string FirstLetterToUpper(this string input)
        {
            switch (input)
            {
                case null:
                    return null;
                case "":
                    return string.Empty;
                default:
                    return char.ToUpper(input.First()) + input.Substring(1);
            }
        }

        public static string FirstLetterToLower(this string input)
        {
            switch (input)
            {
                case null:
                    return null;
                case "":
                    return string.Empty;
                default:
                    return char.ToLower(input.First()) + input.Substring(1);
            }
        }
    }
}
