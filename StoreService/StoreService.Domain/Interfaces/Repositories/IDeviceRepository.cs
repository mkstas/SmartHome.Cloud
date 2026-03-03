using StoreService.Domain.Entities;
using StoreService.Domain.ValueObjects;
    
namespace StoreService.Domain.Interfaces.Repositories
{
    public interface IDeviceRepository
    {
        /// <summary>
        /// Creates a new device with the specified device type, name, and optional image URL.
        /// </summary>
        /// <param name="deviceTypeId"></param>
        /// <param name="name"></param>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        Task CreateAsync(DeviceTypeId deviceTypeId, Name name, ImageUrl? imageUrl);

        /// <summary>
        /// Gets a list of all <see cref="Device"/>.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="Device"/>. If there are no <see cref="Device"/>, an empty list is returned.
        /// </returns>
        Task<List<Device>> GetAllAsync();

        /// <summary>
        /// Gets the <see cref="Device"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// A <see cref="Device"/> with the given id. If there is no <see cref="Device"/> with the given id, null is returned.
        /// </returns>
        Task<Device?> GetOneByIdAsync(DeviceId id);

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
        Task UpdateNameAsync(DeviceId id, Name name);

        /// <summary>
        /// Update the image URL of the <see cref="Device"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        Task UpdateImageUrlAsync(DeviceId id, ImageUrl imageUrl);

        /// <summary>
        /// Delete the image URL of the <see cref="Device"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        Task DeleteImageUrlAsync(DeviceId id, ImageUrl imageUrl);
    }
}
