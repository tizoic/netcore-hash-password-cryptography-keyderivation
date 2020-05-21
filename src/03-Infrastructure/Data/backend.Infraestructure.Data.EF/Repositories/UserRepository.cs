
using backend.Domain.Entities;
using backend.Domain.Repositories;
using backend.Infraestructure.Data.EF.Base;
using backend.Infraestructure.Data.EF.Context;

namespace backend.Infraestructure.Data.EF.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(UserContext userContext) : base(userContext)
        {
        }
    }
}
