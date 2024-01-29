
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class UserEmailRepo : IUserEmailRepo
    {

        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();

        public bool AddUserEmails(List<UserEmail> userEmails)
        {
            try
            {
                if (userEmails != null)
                {
                    context.UserEmails.AddRange(userEmails);
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
            var k = context.UserEmails.Where(a => a.Id == id).FirstOrDefault();
            context.UserEmails.Remove(k);
            context.SaveChanges();
            return 1;
        }

        public UserEmail GetByUserId(int id)
        {
            var k = context.UserEmails.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<UserEmail> GetUsers()
        {
            return context.UserEmails.ToList();
        }

        public bool InsertUser(UserEmail user)
        {
            context.UserEmails.Add(user);
            context.SaveChanges();
            return true;
        }

        public bool UpdateUser(UserEmail user)
        {
            context.UserEmails.Update(user);
            context.SaveChanges();
            return true;
        }
    }
}
