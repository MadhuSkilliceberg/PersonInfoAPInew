using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Models;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserBussinessLogic : IUserBussinessLogic
    {
        private IUserRepository userRepository;
        IUserAddressDetailRepository userAddressDetailRepo;
        IUserCompanyRepo userCompanyRepo;
        IUserContactRepo userContactRepo;
        IRepoUserCourse repoUserCourse;
        IUserEducationDetailRepo userEducationDetailRepo;
        IUserEmailRepo userEmailRepo;
        IUserSkillRepo userSkillRepo;
        IUserTypeRepo userTypeRepo;

        public UserBussinessLogic(
            IUserRepository Repo,
            IUserAddressDetailRepository userAddressDetailRepo,
            IUserCompanyRepo userCompanyRepo,
            IUserContactRepo userContactRepo,
            IRepoUserCourse repoUserCourse,
            IUserEducationDetailRepo userEducationDetailRepo,
            IUserEmailRepo userEmailRepo,
            IUserSkillRepo userSkillRepo,
            IUserTypeRepo userTypeRepo
            )
        {
            userRepository = Repo;
            this.userAddressDetailRepo = userAddressDetailRepo;
            this.userCompanyRepo = userCompanyRepo;
            this.userContactRepo = userContactRepo;
            this.repoUserCourse = repoUserCourse;
            this.userEducationDetailRepo = userEducationDetailRepo;
            this.userEmailRepo = userEmailRepo;
            this.userSkillRepo = userSkillRepo;
            this.userTypeRepo = userTypeRepo;
        }

        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

        public User GetByUserId(int id)
        {
            User user = new User();
            user= userRepository.GetByUserId(id);
            if (user == null)
            {
                return new User();
            }
            return user;
        }

        public List<User> GetByUserRefernceCode(int id)
        {
            User user = new User();
            user = userRepository.GetByUserId(id);
            if (user == null)
            {
                return    userRepository.GetByUserRefernceCode(user.RefferalCode);
            }
            return null;
        }

        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public int InsertUser(User user)
        {
            return userRepository.InsertUser(user);
        }

        public bool UpdateUser(User user)
        {
            return userRepository.UpdateUser(user);
        }

        public List<string> GetNameandMarriageStatus(string status)
        {
            return userRepository.GetNameandMarriageStatus(status);
        }

        public List<string> GetNameByputSkill(string skillname)
        {
            return userRepository.GetNameByputSkill(skillname);
        }

        public List<string> GetUserByPutMedium(string mediumname)
        {
            return userRepository.GetUserByPutMedium(mediumname);
        }

        public List<string> GetUserByPutDesignation(string designationname)
        {
            return userRepository.GetUserByPutDesignation(designationname);
        }





        public List<string> GetUserByPutInstitution(string institutionname)
        {
            return userRepository.GetUserByPutInstitution(institutionname);
        }

        public int GetUserCountByPutGenderName(string gendername)
        {
            return userRepository.GetUserCountByPutGenderName(gendername);

        }

        public List<string> GetUserByPutCountry(string countryName)
        {
            return userRepository.GetUserByPutCountry(countryName);

        }


        public List<string> GetUserByPutState(string statename)
        {
            return userRepository.GetUserByPutState(statename);

        }

        public List<string> GetUserByputcontact(long contect)
        {
            return userRepository.GetUserByputcontact(contect);
        }

        public List<string> GetUserByputfamilycontact(long cont)
        {
            return userRepository.GetUserByputfamilycontact(cont);
        }

        public List<string> GetAllUserdetailesByUser(string User)
        {
            throw new NotImplementedException();
        }

        //public List<string> GetUserByPutState(string statename)
        //{
        //    return userRepository.GetUserByPutState(statename);

        //}

        public bool AddUserTables(UserModels userModels)
        {
            int userId = InsertUser(userModels.user);
            if (userId > 0)
            {

                if (userModels.userAddressDetails != null)
                {
                    userModels.userAddressDetails.UserId = userId;
                    userAddressDetailRepo.AddUserAddressDetail(userModels.userAddressDetails);
                }

                if (userModels.userCompany != null)
                {
                    userModels.userCompany.UserId = userId;
                    userCompanyRepo.AddUserCompany(userModels.userCompany);
                }

                if (userModels.userContact != null)
                {
                    userModels.userContact.UserId = userId;
                    userContactRepo.AddUserContact(userModels.userContact);
                }

                if (userModels.userCourses != null)
                {
                    userModels.userCourses.UserId = userId;
                    repoUserCourse.InsertUserCourse(userModels.userCourses);
                }

                if (userModels.userEducationDetails != null)
                {
                    userModels.userEducationDetails.UserId = userId;
                    userEducationDetailRepo.InsertUserEducationDetail(userModels.userEducationDetails);
                }

                if (userModels.userEmails != null)
                {
                    userModels.userEmails.UserId = userId;
                    userEmailRepo.AddUserEmail(userModels.userEmails);
                }

                if (userModels.userSkills != null)
                {
                    userModels.userSkills.UserId = userId;
                    userSkillRepo.AddUserSkill(userModels.userSkills);
                }

                if (userModels.userTypes != null)
                {
                    userModels.userAddressDetails.UserId = userId;
                    userTypeRepo.InsertUserType(userModels.userTypes);
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool AddUserDetail1(UserDetail userDetail)
        {
            int userId = InsertUser(userDetail.user);
            if (userId > 0)
            {

                if (userDetail.userAddressDetails != null)
                {
                    userDetail.userAddressDetails.ForEach(u => u.UserId = userId);
                    userAddressDetailRepo.AddUserAddressDetails(userDetail.userAddressDetails);
                }

                if (userDetail.userCompanies != null)
                {
                    userDetail.userCompanies.ForEach(u => u.UserId = userId);
                    userCompanyRepo.AddUserCompanies(userDetail.userCompanies);
                }

                if (userDetail.userContacts != null)
                {
                    userDetail.userContacts.ForEach(u => u.UserId = userId);
                    userContactRepo.AddUserContacts(userDetail.userContacts);
                }

                if (userDetail.userCourses != null)
                {
                    userDetail.userCourses.ForEach(u => u.UserId = userId);
                    repoUserCourse.AddUserCoures(userDetail.userCourses);
                }

                if (userDetail.userEducationDetails != null)
                {
                    userDetail.userEducationDetails.ForEach(u => u.UserId = userId);
                    userEducationDetailRepo.InsertUserEducationDetails(userDetail.userEducationDetails);
                }

                if (userDetail.userEmails != null)
                {
                    userDetail.userEmails.ForEach(u => u.UserId = userId);
                    userEmailRepo.AddUserEmails(userDetail.userEmails);
                }

                if (userDetail.userSkills != null)
                {
                    userDetail.userSkills.ForEach(u => u.UserId = userId);
                    userSkillRepo.AddUserSkills(userDetail.userSkills);
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool AddUserDetail(UserDetail userDetail)
        {
            int userId = InsertUser(userDetail.user);
            if (userId > 0)
            {
                if (userDetail.userAddressDetails != null)
                {
                    userDetail.userAddressDetails.ForEach(u => u.UserId = userId);
                    userAddressDetailRepo.UpdateUserAddressDetails(userDetail.userAddressDetails.Where(t => t.Id > 0).ToList());
                    userAddressDetailRepo.AddUserAddressDetails(userDetail.userAddressDetails.Where(t => t.Id < 1).ToList());
                }

                if (userDetail.userCompanies != null)
                {
                    userDetail.userCompanies.ForEach(u => u.UserId = userId);
                    userCompanyRepo.UpdateUserCompanies(userDetail.userCompanies.Where(t => t.Id > 0).ToList());
                    userCompanyRepo.AddUserCompanies(userDetail.userCompanies.Where(t => t.Id <1).ToList());
                }

                if (userDetail.userContacts != null)
                {
                    userDetail.userContacts.ForEach(u => u.UserId = userId);
                    userContactRepo.UpdateUserContacts(userDetail.userContacts.Where(t => t.Id > 0).ToList());
                    userContactRepo.AddUserContacts(userDetail.userContacts.Where(t => t.Id < 1).ToList());
                }

                if (userDetail.userCourses != null)
                {
                    userDetail.userCourses.ForEach(u => u.UserId = userId);
                    repoUserCourse.UpdateUserCourses(userDetail.userCourses.Where(t => t.Id > 0).ToList());
                    repoUserCourse.AddUserCoures(userDetail.userCourses.Where(t => t.Id > 0).ToList());
                }

                if (userDetail.userEducationDetails != null)
                {
                    userDetail.userEducationDetails.ForEach(u => u.UserId = userId);
                    userEducationDetailRepo.UpdateUserEducationDetails(userDetail.userEducationDetails.Where(t => t.Id > 0).ToList());
                    userEducationDetailRepo.InsertUserEducationDetails(userDetail.userEducationDetails.Where(t => t.Id > 0).ToList());
                }

                if (userDetail.userEmails != null)
                {
                    userDetail.userEmails.ForEach(u => u.UserId = userId);
                    userEmailRepo.UpdateUserEmails(userDetail.userEmails.Where(t => t.Id > 0).ToList());
                    userEmailRepo.AddUserEmails(userDetail.userEmails.Where(t => t.Id > 0).ToList());
                }

                if (userDetail.userSkills != null)
                {
                    userDetail.userSkills.ForEach(u => u.UserId = userId);
                    userSkillRepo.UpdateUserSkills(userDetail.userSkills.Where(t => t.Id > 0).ToList());
                    userSkillRepo.AddUserSkills(userDetail.userSkills.Where(t => t.Id > 0).ToList());
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<UserModel> GetUserById(int id)
        {
            UserModel userModel = new UserModel();
            userModel.User =  GetByUserId(id);
            userModel.UserContacts = await userContactRepo.GetUserContactsByUserId(id);
            userModel.UserAddressDetails = await userAddressDetailRepo.GetUserAddressDetailsByUserId(id);
            userModel.UserEmails = await userEmailRepo.GetUserEmailsByUserId(id);
            userModel.UserCompanies
 = await userCompanyRepo.GetUserCompaniesByUserId(id);
            userModel.UserCourses = await repoUserCourse.GetUserCoursesByUserId(id);
            userModel.UserEducationDetails = await userEducationDetailRepo.GetUserEducationDetailsByUserId(id);
            userModel.UserSkills = await userSkillRepo.GetUserSkillsByUserId(id);
            return userModel;
        }

    }
}
