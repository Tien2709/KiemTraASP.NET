using Infrastructure.EF;
using Infrastructure.Entities;
using Infrastructure.Generic;

namespace Infrastructure.Repository
{
    public interface IUserRepository : IRepository<User>
    {
    }

    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(EXDbContext context) : base(context)
        {
        }
    }
}
