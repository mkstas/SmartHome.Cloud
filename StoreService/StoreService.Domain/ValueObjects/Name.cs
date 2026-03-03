using StoreService.Domain.Shared.Helpers;

namespace StoreService.Domain.ValueObjects
{
    /// <summary>
    /// Represents a value object of name.
    /// </summary>
    public record Name
    {
        public const int MAX_LENGTH = 64;

        public string Value { get; }

        /// <summary>
        /// Private constructor with value for <see cref="Name"/>.
        /// </summary>
        /// <param name="value"></param>
        private Name(string value) => Value = value;

        /// <summary>
        /// Factory method to create a new instance of <see cref="Name"/> with the specified value.
        /// </summary>
        /// <remarks>
        /// Parameter <paramref name="value"/> cannot be null, empty or longer than <see cref="MAX_LENGTH"/> characters.
        /// </remarks>
        /// <param name="value"></param>
        /// <returns>
        /// A new <see cref="Name"/> instance.
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Name Create(string value)
        {
            ValidationHelper.CheckNotNullOrEmpty(value, nameof(value));
            ValidationHelper.CheckGreaterThenLimit(value.Length, MAX_LENGTH, nameof(value.Length));

            return new Name(value);
        }
    }
}
