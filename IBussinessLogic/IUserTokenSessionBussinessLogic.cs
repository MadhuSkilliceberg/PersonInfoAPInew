using IdentityModel;
using PersonsInfoV2Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
    public interface IUserTokenSessionBussinessLogic
    {
        Task<IEnumerable<UserTokenSession>> GeUserTokenSessionsAsync();
        Task<UserTokenSession> GetUserTokenSessionByIdAsync(int id);
        Task<UserTokenSession> CreateUserTokenSessionAsync(UserTokenSession entity);
        Task<UserTokenSession> UpdateUserTokenSessionAsync(UserTokenSession entity);
        Task<bool> DeleteUserTokenSessionAsync(int id);
    }
}
