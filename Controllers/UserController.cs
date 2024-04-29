using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.CoustumModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Net.Http.Json;
using System.Xml;
using PersonsInfoV2Api.Models;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        public IUserBussinessLogic Logic;
        public UserController(IUserBussinessLogic use)
        {
            Logic = use;
        }

        [Route("DeleteUsers/{id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return Logic.DeleteUser(id);
        }


        [Route("GetUsersById/{id}")]
        [HttpGet]
        public User GetByUserId(int id)
        {
            return Logic.GetByUserId(id);
        }

        [Route("GetUsersByReferenceCode/{id}")]
        [HttpGet]
        public List<User> GetByUserReferenceCode(int id)
        {
            return Logic.GetByUserRefernceCode(id);
        }


        [Route("GetUsers")]
        [HttpGet]
        public List<User> GetUsers()
        {
            return Logic.GetUsers();
        }


        [Route("AddUsers")]
        [HttpPost]
        public int InsertUser(User user)
        {
            return Logic.InsertUser(user);
        }


        [Route("UpdateUsers")]
        [HttpPut]
        public bool UpdateUser(User user)
        {
            return Logic.UpdateUser(user);
        }

        [Route("GetNameandMarriageStatus")]
        [HttpGet]
        public List<string> GetNameandMarriageStatus(string status)
        {
            return Logic.GetNameandMarriageStatus(status);
        }

        [Route("GetNameByputSkill")]
        [HttpGet]
        public List<string> GetNameByputSkill(string skillname)
        {
            return Logic.GetNameByputSkill(skillname);
        }

        [Route("GetUserByPutMedium")]
        [HttpGet]
        public List<string> GetUserByPutMedium(string mediumname)
        {
            return Logic.GetUserByPutMedium(mediumname);
        }

        [Route("GetUserByPutDesignation")]
        [HttpGet]
        public List<string> GetUserByPutDesignation(string designationname)
        {
            return Logic.GetUserByPutDesignation(designationname);
        }

        [Route("GetUserByPutInstitution")]
        [HttpGet]
        public List<string> GetUserByPutInstitution(string institutionname)
        {
            return Logic.GetUserByPutInstitution(institutionname);
        }

        [Route("GetUserCountByPutGenderName")]
        [HttpGet]
        public int GetUserCountByPutGenderName(string gendername)
        {
            return Logic.GetUserCountByPutGenderName(gendername);
        }

        [Route("GetUserByPutCountry")]
        [HttpGet]
        public List<string> GetUserByPutCountry(string countryName)
        {
            return Logic.GetUserByPutCountry(countryName);

        }

        [Route("GetUserByPutState")]
        [HttpGet]
        public List<string> GetUserByPutState(string statename)
        {
            return Logic.GetUserByPutState(statename);

        }

        [Route("GetUserByputcontact")]
        [HttpGet]
        public List<string> GetUserByputcontact(long contect)
        {
            return Logic.GetUserByputcontact(contect);
        }

        [Route("GetUserByputfamilycontact")]
        [HttpGet]
        public List<string> GetUserByputfamilycontact(long cont)
        {
            return Logic.GetUserByputfamilycontact(cont);
        }

        [Route("AddUserTables")]
        [HttpPost]
        public bool AddUserTables(UserModels userModels)
        {
            return Logic.AddUserTables(userModels);
        }

        [Route("AddUserDetail")]
        [HttpPost]
        public bool AddUserDetail(UserDetail userDetail)
        {
            return Logic.AddUserDetail(userDetail);
        }


        [Route("GetUserData")]
        [HttpGet]
        public object GetUserData()
        {


            var usersData = Context.Users
     .Select(u => new
     {
         UserName = u.FirstName,
         Skills = u.UserSkills
             .Select(s => new
             {
                 SkillId = s.Id,
                 DetailType = "Skills",
                 DetailValue = new
                 {
                     Id = s.Skill.Id,
                     Name = s.Skill.Name
                 }
             }),
         Contacts = u.UserContacts
             .Select(c => new
             {
                 ContactId = c.Id,
                 DetailType = "Contacts",
                 DetailValue = new
                 {
                     Id = c.Id,
                     MobileNumber = c.MobileNumber,
                     ContactType = c.ContactType.Name
                 }
             }),
         Emails = u.UserEmails
             .Select(e => new
             {
                 EmailId = e.Id,
                 DetailType = "Emails",
                 DetailValue = new
                 {
                     Id = e.Id,
                     Email = e.Email,
                     ContactType = e.Type.Name
                 }
             }),
         Courses = u.UserCourses
             .Select(uc => new
             {
                 CourseId = uc.Id,
                 DetailType = "Courses",
                 DetailValue = new
                 {
                     Id = uc.Id,
                     CourseName = uc.Course.Name
                 }
             }),
         EducationDetails = u.UserEducationDetails
             .Select(ed => new
             {
                 EducationDetailId = ed.Id,
                 DetailType = "EducationDetails",
                 DetailValue = new
                 {
                     UserId = ed.UserId,
                     QulificationtypeId = ed.QulificationtypeId,
                     QulificationtypeName = ed.Qulificationtype.Name,
                     YearOFPassout = ed.YearOfpassout,
                     //StartYear = ed.StartDate,
                     //EndYear = ed.EndDate,
                     InstitutionId = ed.InstitutionId,
                     Institution = ed.InstitutionId,
                     Percentage = ed.Percentage
                 }
             }),
         Companies = u.UserCompanies
             .Select(uc => new
             {
                 CompanyId = uc.Id,
                 DetailType = "Companies",
                 DetailValue = new
                 {
                     Id = uc.Id,
                     CompanyName = uc.Company.Name
                 }
             }),
         AddressDetails = u.UserAddressDetails
             .Select(ad => new
             {
                 AddressDetailId = ad.Id,
                 DetailType = "AddressDetails",
                 DetailValue = new
                 {
                     Id = ad.Id,
                     FlotNo = ad.FlotNo,
                     Address1 = ad.Address1,
                     Address2 = ad.Address2,
                     City = ad.City,
                     StateId = ad.StateId,
                     State = ad.State.Name,
                     CountryId = ad.CountryId,
                     Country = ad.Country.Name,
                     UserId = ad.UserId,
                     IsPermanent = ad.IsPermanent
                 }
             }),
         //EducationDetailQualificationType = u.UserEducationDetails
         //    .Select(ed => new
         //    {
         //        EducationDetailId = ed.Id,
         //        DetailType = "EducationDetailQualificationType",
         //        DetailValue = new
         //        {
         //            QulificationTypeId = ed.Qulificationtype.Id,
         //            QulificationTypeName = ed.Qulificationtype.Name
         //        }
         //    }),
     })
     .ToList();

            var result = new
            {
                UsersData = usersData
            };
            // var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            // var json = JsonConvert.SerializeObject(result, Formatting.Indented);
            return result;
        }

        [Route("GetUserData1")]
        [HttpGet]
        public string GetUserData1()
        {
            string data = null;
            SqlConnection con = null;
            try
            {
                string connectionString = @"data source=LAPTOP-CS8AKO34\\SQLEXPRESS; database=PersonsInfoV3New; integrated security=SSPI";
                connectionString = @"Data Source=LAPTOP-CS8AKO34\\SQLEXPRESS;Integrated Security=true;Initial Catalog=PersonsInfoV3New";
                // Creating Connection  
                con = new SqlConnection(connectionString);

                // writing sql query  
                SqlCommand cm = new SqlCommand("[dbo].[get_user_data_json]", con);
                cm.CommandType = CommandType.StoredProcedure;
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();

                while (sdr.Read())
                {
                    data = Convert.ToString(sdr["JSON_F52E2B61-18A1-11d1-B105-00805F49916B"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
            return data;
        }


        //     [Route("GetUserAllData/{id}")]
        //     [HttpGet]
        //     public User GetUserAllData(int id)
        //     {
        //         User user = new User();

        //         user=Context.Users


        ////         user = Context.Users
        ////.Include(u => u.UserAddressDetails)
        ////.Include(u => u.UserCompanies)
        ////.Include(u => u.UserContacts)
        ////.Include(u => u.UserCourses)
        ////.Include(u => u.UserEducationDetails)
        ////.Include(u => u.UserEmails)
        ////.Include(u => u.UserSkills)
        ////.SingleOrDefault(u => u.Id == id);


        //         // Access the related data
        //         //  var allUserDataFromDb = userWithRelatedData?.UserSkills;

        //         return user;
        //     }

        //   [Route("GetUserAllData/{id}")]
        //   [HttpGet]
        //   public object GetUserAllData(int id)

        //   {
        //       var usersData = Context.Users
        //.Select(u => new
        //{

        //    Skills = u.UserSkills.ToList(),

        //    Contacts = u.UserContacts.ToList(),

        //    Emails = u.UserEmails.ToList(),

        //    Courses = u.UserCourses.ToList(),

        //    EducationDetails = u.UserEducationDetails.ToList(),
        //    Companies = u.UserCompanies.ToList(),

        //    AddressDetails = u.UserAddressDetails.ToList(),

        //})
        //.FirstOrDefault();



        //       var result = new
        //       {
        //           UsersData = usersData
        //       };
        //       // var json = JsonConvert.SerializeObject(result, Formatting.Indented);

        //       // var json = JsonConvert.SerializeObject(result, Formatting.Indented);
        //       return usersData;
        //   }

        [Route("GetUserAllData/{id}")]
        [HttpGet]
        public async Task<UserModel> GetUserAllData(int id)
        {
            //UserModel user = new UserModel();
            //user.User = Context.Users.FirstOrDefault(u => u.Id == id);
            //user.UserEmails = Context.UserEmails.Where(u => u.UserId == id).ToList();
            //user.UserContacts = Context.UserContacts.Where(u => u.UserId == id).ToList();
            //user.UserAddressDetails = Context.UserAddressDetails.Where(u => u.UserId == id).ToList();
            //user.UserEducationDetails = Context.UserEducationDetails.Where(u => u.UserId == id).ToList();

            return await Logic.GetUserById(id);
            
        }

    }
}
