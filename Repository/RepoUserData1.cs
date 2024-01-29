using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class RepoUserData1 : IRepoUserData
    {
       // UserData user = new UserData();
        public List<User> GetUserDatasss()
        {


          
            List<User> users = new List<User>();
            foreach(var a in users)
            {
                User user = new User();
                user.Id = Convert.ToInt32(a.Id);
                user.FirstName = Convert.ToString(a.FirstName);
                user.LastName = Convert.ToString(a.LastName);
                user.Dob = Convert.ToDateTime(a.Dob);
               // user.GenderName = Convert.ToString(a.GenderName);
                user.MarritalStatusId = Convert.ToInt32(a.MarritalStatusId);
                user.MobileNumber = Convert.ToInt64(a.MobileNumber);
                user.AadharNumber = Convert.ToInt64(a.AadharNumber);
                user.VoterId = Convert.ToString(a.VoterId);
                user.PanCardNumber = Convert.ToString(a.PanCardNumber);
                users.Add(user);
            }

            return users;


           

    }

    }
}
