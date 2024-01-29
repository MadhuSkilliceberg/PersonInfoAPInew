using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class UserSkillRepository : IUserSkillRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();

        public bool AddUserSkills(List<UserSkill> userSkills)
        {
            try
            {
                if (userSkills != null)
                {
                    person.UserSkills.AddRange(userSkills);
                    person.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int DeleteUser(int id)
        {
            var a = person.UserSkills.Where(c => c.Id == id).FirstOrDefault();
            person.UserSkills.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public UserSkill GetByUserId(int id)
        {
            return person.UserSkills.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<UserSkill> GetUsers()
        {
            return person.UserSkills.ToList();
        }

        public int InsertUser(UserSkill user)
        {
            person.UserSkills.Add(user);
            person.SaveChanges();
            return user.Id;

        }

        public int UpdateUser(UserSkill user)
        {
            person.UserSkills.Update(user);
            person.SaveChanges();
            return user.Id;
        }
    }
}
