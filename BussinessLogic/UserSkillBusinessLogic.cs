using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserSkillBusinessLogic: IUserSkillBusinessLogic
    {
        IUserSkillRepo SkillRepo;

        public  UserSkillBusinessLogic(IUserSkillRepo Repo)
        {
            SkillRepo = Repo;
        }

        public int DeleteUser(int id)
        {
            return SkillRepo.DeleteUser(id);
        }

        public UserSkill GetByUserId(int id)
        {
            return SkillRepo.GetByUserId(id);
        }

        public List<UserSkill> GetUsers()
        {
            return SkillRepo.GetUsers();
        }

        public int InsertUser(UserSkill user)
        {
            return SkillRepo.InsertUser(user);
        }

        public int UpdateUser(UserSkill user)
        {
            return SkillRepo.UpdateUser(user);
        }
    }
}
