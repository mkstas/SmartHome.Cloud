using StoreService.Domain.Shared.Helpers;

namespace StoreService.Domain.ValueObjects
{
    /// <summary>
    /// Represents a value object of image URL.
    /// </summary>
    public record ImageUrl
    {
        public string Value { get; }

        /// <summary>
        /// Private constructor with value for <see cref="ImageUrl"/>.
        /// </summary>
        /// <param name="value"></param>
        private ImageUrl(string value) => Value = value;

        /// <summary>
        /// Factory method to create a new instance of <see cref="ImageUrl"/> with the specified value.
        /// </summary>
        /// <remarks>
        /// Parameter <paramref name="value"/> cannot be null or empty.
        /// </remarks>
        /// <param name="value"></param>
        /// <returns>
        /// A new <see cref="ImageUrl"/> instance.
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ImageUrl Create(string value)
        {
            ValidationHelper.CheckNotNullOrEmpty(value, nameof(value));

            return new ImageUrl(value);
        }
    }
}
