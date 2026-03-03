using StoreService.Domain.ValueObjects;

namespace StoreService.Domain.Entities
{
    /// <summary>
    /// Unique identifier (GUID) of <see cref="Device"/>.
    /// </summary>
    /// <param name="Value"></param>
    public record DeviceId(Guid Value);

    /// <summary>
    /// Represents a device.
    /// </summary>
    public class Device
    {
        public DeviceId Id { get; private set; }
        public DeviceTypeId DeviceTypeId { get; private set; }
        public DeviceType? DeviceType { get; private set; }
        public Name Name { get; private set; }
        public ImageUrl? ImageUrl { get; private set; }

        /// <summary>
        /// Private default constructor for entity framework.
        /// </summary>
#pragma warning disable CS8618
        private Device() { }
#pragma warning restore CS8618

        /// <summary>
        /// Private constructor of <see cref="Device"/> with parameters.
        /// </summary>
        /// <param name="deviceTypeId"></param>
        /// <param name="name"></param>
        /// <param name="imageUrl"></param>
        private Device(DeviceTypeId deviceTypeId, Name name, ImageUrl? imageUrl)
        {
            Id = new DeviceId(Guid.NewGuid());
            DeviceTypeId = deviceTypeId;
            Name = name;
            ImageUrl = imageUrl;
        }

        /// <summary>
        /// Factory method to create a new instance of <see cref="Device"/> with parameters.
        /// </summary>
        /// <param name="deviceTypeId"></param>
        /// <param name="name"></param>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        public static Device Create(DeviceTypeId deviceTypeId, Name name, ImageUrl? imageUrl) =>
            new(deviceTypeId, name, imageUrl);

        /// <summary>
        /// Cnange the device type of the device to <paramref name="deviceTypeId"/>.
        /// </summary>
        /// <param name="deviceTypeId"></param>
        public void ChangeDeviceType(DeviceTypeId deviceTypeId) => DeviceTypeId = deviceTypeId;

        /// <summary>
        /// Change the name of the device to <paramref name="name"/>
        /// </summary>
        /// <param name="name"></param>
        public void ChangeName(Name name) => Name = name;

        /// <summary>
        /// Change the image URL of the device to <paramref name="imageUrl"/>
        /// </summary>
        /// <param name="imageUrl"></param>
        public void ChangeImageUrl(ImageUrl imageUrl) => ImageUrl = imageUrl;

        /// <summary>
        /// Delete the image URL of the device by setting it to <see langword="null"/>.
        /// </summary>
        public void DeleteImageUrl() => ImageUrl = null;
    }
}
