using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class SkillBussinessLogic : ISkillBussinessLogic
    {
        ISkillRepo userRepository;
        public SkillBussinessLogic(ISkillRepo Repo)
        {
            userRepository = Repo;
        }

        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

        public Skill GetByUserId(int id)
        {

            return userRepository.GetByUserId(id);
        }

        public List<Skill> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public int InsertUser(Skill user)
        {
            return userRepository.InsertUser(user);
        }

        public int UpdateUser(Skill user)
        {
            return userRepository.UpdateUser(user);
            
        }

     
    }
}
