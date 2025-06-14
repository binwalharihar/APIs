using Repository.Models;

namespace Repository.IRepo
{
    public interface IAngularUserRepo
    {
        Task<AngularUsers> CreateAsync(AngularUsers user);
        Task<List<AngularUsers>> GetAllAsync();
        Task<AngularUsers?> GetByIdAsync(int id);
        Task<AngularUsers?> UpdateAsync(AngularUsers user);
    }
}
