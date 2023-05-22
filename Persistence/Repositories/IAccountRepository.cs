

using Domain.Entities;

namespace Persistence.Repositories
{
    public interface IAccountRepository
    {
        public Task<List<Account>> GetAllAsync();
        public Task<Account> GetByIdAsync(int id);
        public Task<Account> InsertAsync(Account account);
        public Task<bool> UpdateAsync(Account account);
        public Task<bool> DeleteAsync(Account account);

    }
}
