namespace StoreService.Domain.Shared.Helpers
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Checks if the specified string is <see langword="null"/> or empty.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="paramName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void CheckNotNullOrEmpty(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(paramName, $"{paramName} cannot be null or empty.");
            }
        }

        /// <summary>
        /// Checks if the <paramref name="value"/> greater then <paramref name="limit"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="limit"></param>
        /// <param name="paramName"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void CheckGreaterThenLimit(double value, double limit, string paramName)
        {
            if (value > limit)
            {
                throw new ArgumentOutOfRangeException(paramName, $"${paramName} cannot be greater then {limit}");
            }
        }
    }
}
