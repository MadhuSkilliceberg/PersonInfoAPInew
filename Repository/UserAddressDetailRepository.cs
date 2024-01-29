using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class UserAddressDetailRepository : IUserAddressDetailRepo
    {
        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();

        public bool AddUserAddressDetails(List<UserAddressDetail> userAddressDetails)
        {
            try
            {
                if (userAddressDetails != null)
                {
                    context.UserAddressDetails.AddRange(userAddressDetails);
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
            var k = context.UserAddressDetails.Where(a => a.Id == id).FirstOrDefault();
            context.UserAddressDetails.Remove(k);
            context.SaveChanges();
            return 1;
        }

        public UserAddressDetail GetByUserId(int id)
        {
            var k = context.UserAddressDetails.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<UserAddressDetail> GetUsers()
        {
            var result = (from s in context.UserAddressDetails
                         join l1 in context.LookUpValues
                         on s.TypeId equals l1.Id
                          join l2 in context.States
                         on s.StateId equals l2.Id
                          join l3 in context.Countries
                         on s.CountryId equals l3.Id
                          select new UserAddressDetail
                         {
                             /****** Script for SelectTopNRows command from SSMS  ******/

                           Address1=  s.Address1,
                             Address2= s.Address2,
                             City   = s.City,
                             StateId=  s.StateId,
                             CountryId=     s.CountryId,
                             UserId=  s.UserId,
                             IsPermanent=  s.IsPermanent,
                             CreatedOn=  s.CreatedOn,
                             CreatedBy =  s.CreatedBy,
                             UpdatedOn = s.UpdatedOn,
                             UpdatedBy = s.UpdatedBy,
                             TypeId = s.TypeId,
                             TypeValue = l1.Name,
                             StateName=l2.Name,
                             CountryName=l3.Name,

                          }).ToList();
           

            return result;

           
        }

        public bool InsertUser(UserAddressDetail user)
        {
            context.UserAddressDetails.Add(user);
            context.SaveChanges();
            return true;

        }

        public bool UpdateUser(UserAddressDetail user)
        {
            context.UserAddressDetails.Update(user);
            context.SaveChanges();
            return true;
        }
    }
}
