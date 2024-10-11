using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserTokenSessionBussinessLogic : IUserTokenSessionBussinessLogic
    {
        private readonly IGenericRepository<UserTokenSession> _userTokenSessionRepository;

        public UserTokenSessionBussinessLogic(IGenericRepository<UserTokenSession> userTokenSessionRepository)
        {
            _userTokenSessionRepository = userTokenSessionRepository;
        }
        public async Task<UserTokenSession> CreateUserTokenSessionAsync(UserTokenSession entity)
        {
            return await _userTokenSessionRepository.AddAsync(entity);
        }

        public async Task<bool> DeleteUserTokenSessionAsync(int id)
        {
            return await _userTokenSessionRepository.DeleteAsync(id);
        }

        public async Task<UserTokenSession> GetUserTokenSessionByIdAsync(int id)
        {
            return await _userTokenSessionRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<UserTokenSession>> GeUserTokenSessionsAsync()
        {
            return await _userTokenSessionRepository.GetAllAsync();
        }

        public async Task<UserTokenSession> UpdateUserTokenSessionAsync(UserTokenSession entity)
        {
            return await _userTokenSessionRepository.UpdateAsync(entity);
        }
    }
}
