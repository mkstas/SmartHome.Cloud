using StoreService.Domain.Entities;
using StoreService.Domain.ValueObjects;

namespace StoreService.Domain.Interfaces.Repositories
{
    public interface IDeviceTypeRepository
    {
        /// <summary>
        /// Creates a new <see cref="DeviceType"/> with the name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task CreateAsync(Name name);

        /// <summary>
        /// Gets a list of all <see cref="DeviceType"/>.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="DeviceType"/>. If there are no <see cref="DeviceType"/>, an empty list is returned.
        /// </returns>
        Task<List<DeviceType>> GetAllAsync();

        /// <summary>
        /// Gets the <see cref="DeviceType"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// A <see cref="DeviceType"/> with the given id. If there is no <see cref="DeviceType"/> with the given id, null is returned.
        /// </returns>
        Task<DeviceType?> GetOneByIdAsync(DeviceTypeId id);

        /// <summary>
        /// Update the name of the <see cref="DeviceType"/> with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        Task UpdateAsync(DeviceTypeId id, Name name);
    }
}
