using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserDataBussinessLogic : IbussiUserData
    {
        IRepoUserData repoUserData;
        public UserDataBussinessLogic(IRepoUserData repo)
        {
            repoUserData = repo;
        }

        public List<User> GetUserDatasss()
        {
            return repoUserData.GetUserDatasss();
        }
        //public List<UserData> GetUserDatasss()
        //{
        //   return repoUserData.GetUserDatasss();
        //}
    }
}
