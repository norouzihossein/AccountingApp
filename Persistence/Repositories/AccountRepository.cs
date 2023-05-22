

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly RepositoryDbContext _repositoryDbContext;
        public AccountRepository(RepositoryDbContext repositoryDbContext)
        {
            _repositoryDbContext = repositoryDbContext;
        }
        public async Task<List<Account>> GetAllAsync()
        {
            return await _repositoryDbContext.Account.ToListAsync();
        }
        public async Task<Account> GetByIdAsync(int id)
        {
            return await _repositoryDbContext.Account.FindAsync(id);
        }
        public async Task<Account> InsertAsync(Account account)
        {
            await _repositoryDbContext.AddAsync(account);
            await _repositoryDbContext.SaveChangesAsync();
            return account;

        }
        public async Task<bool> UpdateAsync(Account account)
        {
            try
            {
                _repositoryDbContext.Entry(account).State = EntityState.Modified;
                await _repositoryDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public async Task<bool> DeleteAsync(Account account)
        {
            try
            {
                _repositoryDbContext.Entry(account).State = EntityState.Deleted;
                await _repositoryDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
