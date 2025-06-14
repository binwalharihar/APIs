using Services.Common;
using Services.DTOs;

namespace Services.IServices
{
    public interface IAngularUsersService
    {

        Task<GenericResult> GetAllAsync();
        Task<GenericResult> CreateAsync(AngularUsersDTO angularUsersDTO);
        Task<GenericResult> GetByIdAsync(int id);
        Task<GenericResult> UpdateAsync(AngularUsersDTO angularUsersDTO);
    }
}
