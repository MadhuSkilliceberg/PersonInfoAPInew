using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IUserSkillRepo
    {
        public List<UserSkill> GetUsers();
        public int InsertUser(UserSkill user);

        public int UpdateUser(UserSkill user);

        public int DeleteUser(int id);

        public UserSkill GetByUserId(int id);
        public bool AddUserSkills(List<UserSkill> userSkills);

    }
}
