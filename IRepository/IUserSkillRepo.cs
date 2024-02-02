using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IUserSkillRepo
    {
        public Task<List<UserSkill>> GetUserSkills();

        public Task<List<UserSkill>> GetUserSkillsByUserId(int UserId);

        public Task<int> AddUserSkill(UserSkill user);

        public Task<int> UpdateUserSkill(UserSkill user);

        public Task<UserSkill> GetUserSkillById(int id);

        public Task<int> DeleteUserSkillById(int id);

        public Task<int> AddUserSkills(List<UserSkill> userSkills);

        public Task<int> UpdateUserSkills(List<UserSkill> userSkills);

    }
}
