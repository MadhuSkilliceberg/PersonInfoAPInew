using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class UserTypeRepository : IUserTypeRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteUserType(int id)
        {
            var a = person.UserTypes.Where(c => c.Id == id).FirstOrDefault();
            person.UserTypes.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public UserType GetByUserTypeId(int id)
        {
            return person.UserTypes.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<UserType> GetUserTypes()
        {
            return person.UserTypes.ToList();
        }

        public bool InsertUserType(UserType UserType)
        {
            person.UserTypes.Add(UserType);
            person.SaveChanges();
            return true;

        }

        public bool UpdateUserType(UserType UserType)
        {
            person.UserTypes.Update(UserType);
            person.SaveChanges();
            return true;
        }
    }
}
