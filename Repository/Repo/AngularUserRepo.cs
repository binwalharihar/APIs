using Microsoft.EntityFrameworkCore;
using Repository.DataContext;
using Repository.IRepo;
using Repository.Models;

namespace Repository.Repo
{
    public class AngularUserRepo(AngularDataContext context) : IAngularUserRepo
    {
        private readonly AngularDataContext _context = context;

        public async Task<List<AngularUsers>> GetAllAsync()
        {
            return await _context.AngularUsers.ToListAsync();
        }

        public async Task<AngularUsers> CreateAsync(AngularUsers user)
        {
            await _context.AngularUsers.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<AngularUsers?> GetByIdAsync(int id)
        {
            return await _context.AngularUsers.FindAsync(id);
        }

        public async Task<AngularUsers?> UpdateAsync(AngularUsers user)
        {
            _context.AngularUsers.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
