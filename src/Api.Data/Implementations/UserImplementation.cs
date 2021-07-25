using System.Threading.Tasks;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class UserImplementation : BaseRepository<User>, IUserRepository
    {
        private DbSet<User> _dataset;

        public UserImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<User>();
        }

        public async Task<User> FindByLogin(string email)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }


    }
}
