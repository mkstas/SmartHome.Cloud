using StoreService.Domain.Entities;
using StoreService.Domain.ValueObjects;

namespace StoreService.Domain.Interfaces.Services
{
    public interface IDeviceTypeService
    {
        /// <summary>
        /// Creates a new <see cref="DeviceType"/> with the name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task CreateDeviceTypeAsync(Name name);

        /// <summary>
        /// Gets a list of all <see cref="DeviceType"/>.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="DeviceType"/>. If there are no <see cref="DeviceType"/>, an empty list is returned.
        /// </returns>
        Task<List<DeviceType>> GetAllDeviceTypeAsync();

        /// <summary>
        /// Gets the <see cref="DeviceType"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// A <see cref="DeviceType"/> with the given id. If there is no <see cref="DeviceType"/> with the given id, null is returned.
        /// </returns>
        Task<DeviceType?> GetOneDeviceTypeByIdAsync(DeviceTypeId id);

        /// <summary>
        /// Update the name of the <see cref="DeviceType"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        Task UpdateDeviceTypeAsync(DeviceTypeId id, Name name);
    }
}
