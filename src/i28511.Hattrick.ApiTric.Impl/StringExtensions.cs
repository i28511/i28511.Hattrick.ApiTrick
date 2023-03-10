
namespace i28511.Hattrick.ApiTrick.Impl
{
    internal static class StringExtensions
    {
        public static string ToLowerFirstChar(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToLowerInvariant(input[0]) + input[1..];
        }

        /// <summary>
        /// Converts to nullabledatetime.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        public static DateTime? ToNullableDateTime(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return null;
            }

            return DateTime.ParseExact(s, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts to datetime.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string s)
        {
            return DateTime.ParseExact(s, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts to bool.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static bool ToBool(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            return s.ToUpperInvariant() == "TRUE";
        }
    }



}
