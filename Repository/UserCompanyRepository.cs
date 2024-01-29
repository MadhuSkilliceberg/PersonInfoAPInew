using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class UserCompanyRepository : IUserCompanyRepo
    {
        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();

        public bool AddUserCompanies(List<UserCompany> userCompanies)
        {
            try
            {
                if (userCompanies != null)
                {
                    context.UserCompanies.AddRange(userCompanies);
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
            var o = context.UserCompanies.Where(a => a.Id == id).FirstOrDefault();
            context.UserCompanies.Remove(o);
            context.SaveChanges();
            return 1;
        }

        public UserCompany GetByUserId(int id)
        {
            var k = context.UserCompanies.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<UserCompany> GetUsers()
        {
            return context.UserCompanies.ToList();
        }

        public int InsertUser(UserCompany user)
        {
            context.UserCompanies.Add(user);
            context.SaveChanges();
            return user.Id;
        }

        public int UpdateUser(UserCompany user)
        {
            context.UserCompanies.Update(user);
            context.SaveChanges();
            return user.Id;
        }
    }
}
