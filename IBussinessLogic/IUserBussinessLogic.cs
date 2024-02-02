using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
    public interface IUserBussinessLogic
    {
        public List<User> GetUsers();
        public int InsertUser(User user);

        public bool UpdateUser(User user);

        public int DeleteUser(int id);

        public User GetByUserId(int id);

        public List<string> GetNameandMarriageStatus(string status);
        public List<string> GetNameByputSkill(string skillname);
        public List<string> GetUserByPutMedium(string mediumname);
        public List<string> GetUserByPutDesignation(string designationname);
        public List<string> GetUserByPutInstitution(string institutionname);
        public int GetUserCountByPutGenderName(string gendername);
        public List<string> GetUserByPutCountry(string countryName);
        public List<string> GetUserByPutState(string statename);
        public List<string> GetUserByputcontact(long contect);
        public List<string> GetUserByputfamilycontact(long cont);
        public List<string> GetAllUserdetailesByUser(string User);

        public bool AddUserTables(UserModels userModels);

        public bool AddUserDetail(UserDetail userDetail);


        //  public List<string> GetUserByPutState(string statename);

        public Task<UserModel> GetUserById(int id);




    }
}
