using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class UserContactRepo : IUserContactRepo
    {

        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();

        public bool AddUserContacts(List<UserContact> userContacts)
        {
            try
            {
                if (userContacts != null)
                {
                    context.UserContacts.AddRange(userContacts);
                    context.SaveChanges();
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
            var k = context.UserContacts.Where(a => a.Id == id).FirstOrDefault();
            context.UserContacts.Remove(k);
            context.SaveChanges();
            return 1;
        }

        public UserContact GetByUserId(int id)
        {
            var k = context.UserContacts.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<UserContact> GetUsers()
        {

            return context.UserContacts.ToList();
        }

        public bool InsertUser(UserContact user)
        {
            context.UserContacts.Add(user);
            context.SaveChanges();
            return true;
        }

        public bool UpdateUser(UserContact user)
        {
            context.UserContacts.Update(user);
            context.SaveChanges();
            return true;
        }
    }
}
