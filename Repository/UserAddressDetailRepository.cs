using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class UserAddressDetailRepository : IUserAddressDetailRepository
    {
        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();

        public async Task<int> AddUserAddressDetails(List<UserAddressDetail> userAddressDetails)
        {
            try
            {
                if (userAddressDetails != null)
                {
                    context.UserAddressDetails.AddRange(userAddressDetails);
                   await context.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }         
        }

        public async Task<int> AddUserAddressDetail(UserAddressDetail userAddressDetails)
        {
           
                    context.UserAddressDetails.Add(userAddressDetails);
                    await context.SaveChangesAsync();
                    return 1;    
        }

        public async Task<int> DeleteUserAddressDetailById(int id)
        {
            var k = context.UserAddressDetails.Where(a => a.Id == id).FirstOrDefault();
            context.UserAddressDetails.Remove(k);
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<UserAddressDetail> GetUserAddressDetailsById(int id)
        {
            var k =await context.UserAddressDetails.Where(a => a.Id == id).FirstOrDefaultAsync();
            return k;
        }

        public async Task<List<UserAddressDetail>> GetUserAddressDetails()
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
                             //TypeValue = l1.Name,
                             //StateName=l2.Name,
                             //CountryName=l3.Name,

                          }).ToList();
           

            return result;

           
        }

        public async Task<List<UserAddressDetail>> GetUserAddressDetailsByUserId(int userId)
        {
            var result = (from s in context.UserAddressDetails.Where(t=>t.UserId== userId)
                          join l1 in context.LookUpValues
                          on s.TypeId equals l1.Id
                          join l2 in context.States
                         on s.StateId equals l2.Id
                          join l3 in context.Countries
                         on s.CountryId equals l3.Id
                          select new UserAddressDetail
                          {
                              /****** Script for SelectTopNRows command from SSMS  ******/

                              Address1 = s.Address1,
                              Address2 = s.Address2,
                              City = s.City,
                              StateId = s.StateId,
                              CountryId = s.CountryId,
                              UserId = s.UserId,
                              IsPermanent = s.IsPermanent,
                              CreatedOn = s.CreatedOn,
                              CreatedBy = s.CreatedBy,
                              UpdatedOn = s.UpdatedOn,
                              UpdatedBy = s.UpdatedBy,
                              TypeId = s.TypeId,
                              //TypeValue = l1.Name,
                              //StateName=l2.Name,
                              //CountryName=l3.Name,

                          }).ToList();


            return result;


        }

        public async  Task<int> InsertUserAddressDetails(UserAddressDetail userAddressDetail)
        {
           await context.UserAddressDetails.AddAsync(userAddressDetail);
           await context.SaveChangesAsync();
            return 1;

        }

        public async Task<int> UpdateUserAddressDetail(UserAddressDetail userAddressDetails)
        {
            context.UserAddressDetails.Update(userAddressDetails);
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> UpdateUserAddressDetails(List<UserAddressDetail> userAddressDetail)
        {
            context.UserAddressDetails.UpdateRange(userAddressDetail);
            await context.SaveChangesAsync();
            return 1;
        }

        
    }
}
