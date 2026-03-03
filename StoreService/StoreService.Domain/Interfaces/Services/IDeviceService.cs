using StoreService.Domain.Entities;
using StoreService.Domain.ValueObjects;

namespace StoreService.Domain.Interfaces.Services
{
    public interface IDeviceService
    {
        /// <summary>
        /// Creates a new device with the specified device type, name, and optional image URL.
        /// </summary>
        /// <param name="deviceTypeId"></param>
        /// <param name="name"></param>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        Task CreateDeviceAsync(DeviceTypeId deviceTypeId, Name name, ImageUrl? imageUrl);

        /// <summary>
        /// Gets a list of all <see cref="Device"/>.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="Device"/>. If there are no <see cref="Device"/>, an empty list is returned.
        /// </returns>
        Task<List<Device>> GetAllDeviceAsync();

        /// <summary>
        /// Gets the <see cref="Device"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// A <see cref="Device"/> with the given id. If there is no <see cref="Device"/> with the given id, null is returned.
        /// </returns>
        Task<Device?> GetDeviceByIdAsync(DeviceId id);

        /// <summary>
        /// Update the device type of the <see cref="Device"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deviceTypeId"></param>
        /// <returns></returns>
        Task UpdateDeviceTypeAsync(DeviceId id, DeviceTypeId deviceTypeId);

        /// <summary>
        /// Update the name of the <see cref="Device"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        Task UpdateDeviceNameAsync(DeviceId id, Name name);

        /// <summary>
        /// Update the image URL of the <see cref="Device"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        Task UpdateDeviceImageUrlAsync(DeviceId id, ImageUrl imageUrl);

        /// <summary>
        /// Delete the image URL of the <see cref="Device"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        Task DeleteDeviceImageUrlAsync(DeviceId id, ImageUrl imageUrl);
    }
}
