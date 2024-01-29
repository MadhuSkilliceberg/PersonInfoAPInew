using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class UserEducationDetailRepo: IUserEducationDetailRepo
    {
        PersonsInfoV3NewContext persons = new PersonsInfoV3NewContext();

        public bool AddUserEducationDetails(List<UserEducationDetail> userEducationDetails)
        {
            try
            {
                if (userEducationDetails != null)
                {
                    persons.UserEducationDetails.AddRange(userEducationDetails);
                    persons.SaveChanges();
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
            var k = persons.UserEducationDetails.Where(a => a.Id == id).FirstOrDefault();
            persons.UserEducationDetails.Remove(k);
            persons.SaveChanges();
            return 1;
        }

        public UserEducationDetail GetByUserId(int id)
        {
            var l = persons.UserEducationDetails.Where(a => a.Id == id).FirstOrDefault();
            return l;
        }

        public List<UserEducationDetail> GetUsers()
        {
            return persons.UserEducationDetails.ToList(); ;
        }

        public int InsertUser(UserEducationDetail user)
        {
            persons.UserEducationDetails.Add(user);
            persons.SaveChanges();
            return user.Id;
        }

        public int UpdateUser(UserEducationDetail user)
        {
            persons.UserEducationDetails.Update(user);
            persons.SaveChanges();
            return user.Id;
        }
    }
}
