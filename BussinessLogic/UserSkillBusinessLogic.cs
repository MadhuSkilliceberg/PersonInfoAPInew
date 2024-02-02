using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.Repository;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserSkillBusinessLogic: IUserSkillBusinessLogic
    {
        IUserSkillRepo userSkillRepo;

        public  UserSkillBusinessLogic(IUserSkillRepo Repo)
        {
            userSkillRepo = Repo;
        }

        public async Task<int> DeleteUserSkillById(int id)
        {
            return await userSkillRepo.DeleteUserSkillById(id);
        }

        public async Task<List<UserSkill>> GetUserSkills()
        {
            return await userSkillRepo.GetUserSkills();
        }

        public async Task<UserSkill> GetUserSkillById(int id)
        {
            return await userSkillRepo.GetUserSkillById(id);
        }

        public async Task<int> AddUserSkill(UserSkill userSkill)
        {
            return await userSkillRepo.AddUserSkill(userSkill);
        }

        public async Task<int> AddUserSkills(List<UserSkill> userSkill)
        {
            return await userSkillRepo.AddUserSkills(userSkill);
        }

        public async Task<int> UpdateUserSkill(UserSkill userSkill)
        {
            return await userSkillRepo.UpdateUserSkill(userSkill);
        }

        public async Task<int> UpdateUserSkills(List<UserSkill> userSkill)
        {
            return await userSkillRepo.UpdateUserSkills(userSkill);
        }

        public async Task<List<UserSkill>> GetUserSkillsByUserId(int userId)
        {
            return await userSkillRepo.GetUserSkillsByUserId(userId);
        }
    }
}
