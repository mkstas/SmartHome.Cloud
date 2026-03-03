using StoreService.Domain.ValueObjects;

namespace StoreService.Domain.Entities
{
    /// <summary>
    /// Unique identifier (GUID) of <see cref="DeviceType"/>.
    /// </summary>
    /// <param name="Value"></param>
    public record DeviceTypeId(Guid Value);

    /// <summary>
    /// Represents a device type.
    /// </summary>
    public class DeviceType
    {
        public DeviceTypeId Id { get; private set; }
        public Name Name { get; private set; }
        public List<Device> Devices { get; private set; } = [];

        /// <summary>
        /// Private default constructor for entity framework.
        /// </summary>
#pragma warning disable CS8618
        private DeviceType() { }
#pragma warning restore CS8618

        /// <summary>
        /// Private constructor of <see cref="DeviceType"/> with <paramref name="name"/>.
        /// </summary>
        /// <param name="name"></param>
        private DeviceType(Name name)
        {
            Id = new DeviceTypeId(Guid.NewGuid());
            Name = name;
        }

        /// <summary>
        /// Factory method to create a new instance of <see cref="DeviceType"/> with <paramref name="name"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// A new <see cref="DeviceType"/> instance.
        /// </returns>
        public static DeviceType Create(Name name) => new(name);

        /// <summary>
        /// Change the name of the device type to <paramref name="name"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public void ChangeName(Name name) => Name = name;
    }
}
