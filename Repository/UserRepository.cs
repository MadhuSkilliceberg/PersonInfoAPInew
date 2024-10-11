using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.CoustumModels;

namespace PersonsInfoV2Api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly PersonsInfoV3NewContext context;


        //PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();
        public UserRepository(PersonsInfoV3NewContext context)
        {
            this.context = context;
        }

        public List<User> GetUsers()
        {
            return context.Users.ToList();


            // List<User> users = new List<User>();
            //var ravi = context.Users.ToList();
            //foreach( var a in ravi)
            //{
            //    var b = context.Genders.ToList();
            //    foreach( var c in b)
            //    {
            //        User user = new User();
            //        user.FirstName = Convert.ToString(a.FirstName);
            //        c.GenderName = Convert.ToString(c.GenderName);


            //    }

            //}
            //for (int i = 0; i < users.Count; i++)
            //{
            //    //var  a = users[i].Dob;
            //    //var b = Convert.ToInt32(a);
            //    //DateTime dt = new DateTime(06/02/2023);
            //    //var c = Convert.ToInt32(dt);
            //    //var d = (c - b);
            //    //var e= Convert.ToInt32(d);
            //    DateTime nowdate = DateTime.Now;
            //    DateTime udate = Convert.ToDateTime(users[i].Dob);

            //    var age = Convert.ToInt32(nowdate.Year - udate.Year);

            //    if (age > 18)
            //    {
            //        users[i].FirstName = users[i].FirstName + "." + users[i].LastName;
            //    }
            //    else
            //    {
            //        users[i].FirstName = users[i].FirstName;
            //    }



            //}

            //or 
            //foreach(var u in users)
            //{
            //    u.FirstName = u.FirstName + "." + u.LastName;
            //}

            // return users;
        }
        public List<string> GetNameandMarriageStatus(string status)
        {
            List<string> vs = new List<string>();

            var gender = context.MarritalStatuses.Where(a => a.Name == status).FirstOrDefault();
            var names = context.Users.Where(t => t.MarritalStatusId == gender.Id).ToList();
            foreach (var data in names)
            {
                var marry = context.Genders.Where(a => a.Id == data.GenderId).ToList();
                foreach (var sat in marry)
                {
                    var a = $"{data.FirstName}  {data.LastName}  {data.Dob}  {gender.Name} {data.MobileNumber} " +
                        $" {data.PanCardNumber}  {data.AadharNumber}  {data.VoterId} {sat.Name} {sat.Code}";
                    vs.Add(a);
                }
            }
            return vs;
        }


        public List<string> GetNameByputSkill(string skillname)
        {
            List<string> lost = new List<string>();


            var skill = context.Skills.Where(a => a.Name == skillname).FirstOrDefault();
            var usersk = context.UserSkills.Where(a => a.SkillId == skill.Id).ToList();

            foreach (var data in usersk)
            {
                var skuser = context.Users.Where(a => data.UserId == a.Id).ToList();
                foreach (var Bhanu in skuser)
                {
                    var vamshi = ($"{Bhanu.FirstName} {Bhanu.LastName} {Bhanu.MobileNumber} {Bhanu.AadharNumber}" +
                        $" {Bhanu.PanCardNumber} {Bhanu.Gender} {skill.Name} {Bhanu.MarritalStatus} ");
                    lost.Add(vamshi);
                }
            }
            return lost;
        }


        public int InsertUser(User user)
        {
            try
            {
                context.Users.Add(user);
                context.SaveChanges();
                return user.Id;
            }catch(Exception ex)
            {
                return 0;
            }
        }

        public bool UpdateUser(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
            return true;
        }

        public int DeleteUser(int id)
        {
            var k = context.Users.Where(a => a.Id == id).FirstOrDefault();
            context.Users.Remove(k);
            context.SaveChanges();
            return 1;
        }

        public User GetByUserId(int id)
        {
            return context.Users.Where(a => a.Id == id).FirstOrDefault();
        }

        public List<User> GetByUserRefernceCode(string refferalCode)
        {
            return context.Users.Where(a => a.RefferalCode == refferalCode).ToList();
        }

       
        public List<string> GetUserByPutMedium(string mediumname)
        {
            List<string> Rose = new List<string>();
            var teddy = context.Media.Where(a => a.Name == mediumname).FirstOrDefault();
            var purpose = context.Institutions.Where(a => a.MediumId == teddy.Id).ToList();
            foreach (var abc in purpose)
            {
                var def = context.QulificationTypes.Where(a => a.Id == abc.QulificationTypeId).ToList();
                foreach (var ghi in def)
                {
                    var jkl = context.UserEducationDetails.Where(a => a.QulificationtypeId == ghi.Id).ToList();
                    foreach (var mno in jkl)
                    {
                        var pqr = context.Users.Where(a => a.Id == mno.UserId).ToList();
                        foreach (var stu in pqr)
                        {
                            var vwx = ($"{stu.FirstName} {stu.LastName} {stu.Dob} {stu.VoterId} {stu.PanCardNumber} {stu.AadharNumber}" +
                                $" {ghi.Name} {abc.InstitutionName} {teddy.Name} " +
                                $" {mno.Percentage} ");
                            Rose.Add(vwx);
                        }
                    }
                }
            }
            return Rose;
        }

        public List<string> GetUserByPutDesignation(string designationname)
        {
            List<string> Rose = new List<string>();
            var desig = context.Designations.Where(a => a.Name == designationname).FirstOrDefault();
            var usercompany = context.UserCompanies.Where(a => a.DesignationId == desig.Id).ToList();
            foreach (var abc in usercompany)
            {
                var def = context.CompanyAddresses.Where(a => abc.CompanyId == a.Id).ToList();
                foreach (var ghi in def)
                {
                    var jkl = context.Countries.Where(a => ghi.CountryId == a.Id).ToList();
                    foreach (var mno in jkl)
                    {
                        var pqr = context.CoutryStates.Where(a => mno.Id == a.CountryId).ToList();
                        foreach (var stu in pqr)
                        {
                            var vwx = context.States.Where(a => stu.StateId == a.Id).ToList();
                            foreach (var yz in vwx)
                            {
                                var cba = context.CompanyAddresses.Where(a => yz.Id == a.StateId).ToList();
                                foreach (var fed in cba)
                                {
                                    var bhanu = context.Companies.Where(a => fed.CompanyId == a.Id).ToList();
                                    foreach (var raju in bhanu)
                                    {
                                        var chandu = context.CompanyAddresses.Where(a => raju.Id == a.CompanyId).ToList();
                                        foreach (var vamshi in chandu)
                                        {
                                            var srikanth = context.UserCompanies.Where(a => vamshi.CompanyId == a.CompanyId).ToList();
                                            foreach (var deepak in srikanth)
                                            {
                                                var shravan = context.Users.Where(a => deepak.UserId == a.Id).ToList();
                                                foreach (var rahul in shravan)
                                                {
                                                    var priya = ($"{rahul.FirstName}  {rahul.LastName} {desig.Name}" +
                                                        $" {abc.DesignationId} {rahul.Dob}  {vamshi.City} {raju.Name}" +
                                                        $" {yz.Name} {mno.Name} {ghi.CompanyId} ");
                                                    Rose.Add(priya);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return Rose;
        }

        public List<string> GetUserByPutInstitution(string institutionname)
        {
            List<string> Rose = new List<string>();
            var abc = context.Institutions.Where(a => a.InstitutionName == institutionname).FirstOrDefault();
            var def = context.Media.Where(a => abc.MediumId == a.Id).ToList();
            foreach (var ghi in def)
            {
                var ijk = context.Institutions.Where(a => ghi.Id == a.Id).ToList();
                foreach (var jkl in ijk)
                {
                    var lkm = context.QulificationTypes.Where(a => jkl.QulificationTypeId == a.Id).ToList();
                    foreach (var mno in lkm)
                    {
                        var opq = context.UserEducationDetails.Where(a => mno.Id == a.QulificationtypeId).ToList();
                        foreach (var qrs in opq)
                        {
                            var stu = context.Users.Where(a => qrs.UserId == a.Id).ToList();
                            foreach (var uvw in stu)
                            {
                                var wxy = ($"{uvw.FirstName}  {uvw.LastName} {uvw.VoterId} {uvw.Dob} {uvw.MobileNumber} {uvw.PanCardNumber} " +
                                    $"{jkl.InstitutionName}  {mno.Name}  {ghi.Name} " +
                                    $" {qrs.Percentage} ");
                                Rose.Add(wxy);
                            }
                        }
                    }
                }
            }
            return Rose;
        }

        public int GetUserCountByPutGenderName(string gendername)
        {


            var data = context.Genders.Where(a => a.Name == gendername).FirstOrDefault();

            var aata = context.Users.Where(a => a.GenderId == data.Id).ToList();
            //foreach(var aa in aata)
            //{
            //    var abc = ($"{aa.GenderId}");

            //    Rose.Add(abc);
            //    object count = Rose.Count();


            //}

            return aata.Count();



        }

        public List<string> GetUserByPutCountry(string countryName)
        {
            List<string> Rose = new List<string>();
            var abc = context.Countries.Where(a => a.Name == countryName).FirstOrDefault();
            //var cde = context.CoutryStates.Where(a => a.CountryId == abc.Id).ToList(); 

            var kjl = context.UserAddressDetails.Where(a => a.CountryId == abc.Id).ToList();
            foreach (var efg in kjl)
            {
                var mno = context.Users.Where(a => a.Id == efg.UserId).ToList();
                foreach (var ijk in mno)
                {
                    var vinay = ($"{ijk.FirstName}  {ijk.LastName}  {ijk.Dob}  {ijk.MobileNumber} {efg.Address1} ");
                    Rose.Add(vinay);
                }
            }
            return Rose;

        }

        public List<string> GetUserByPutState(string statename)
        {
            List<string> Rose = new List<string>();
            var abc = context.States.Where(a => a.Name == statename).FirstOrDefault();
            var kjl = context.UserAddressDetails.Where(a => a.StateId == abc.Id).ToList();
            foreach (var efg in kjl)
            {
                var mno = context.Users.Where(a => a.Id == efg.UserId).ToList();
                foreach (var ijk in mno)
                {
                    var vinay = ($"{ijk.FirstName}  {ijk.LastName}  {ijk.Dob}  {ijk.MobileNumber} {efg.Address1} ");
                    Rose.Add(vinay);
                }
            }
            return Rose;



        }
        public List<string> GetUserByputcontact(long contect)
        {
            List<string> bhanu = new List<string>();
            var s = context.UserContacts.Where(a => a.MobileNumber == contect).FirstOrDefault();
            var j = context.Users.Where(a => a.Id == s.Id).ToList();
            foreach (var k in j)
            {
                var nuvvu = ($"{s.MobileNumber}   {k.FirstName}");
                bhanu.Add(nuvvu);
            }
            return bhanu;
        }

        public List<string> GetUserByputfamilycontact(long cont)
        {
            List<string> chandhu = new List<string>();
            var famcontact = context.FamilyContacts.Where(a => a.MobileNumber == cont).FirstOrDefault();
            var can = context.Families.Where(a => a.Id == famcontact.FamilyId).ToList();
            foreach (var h in can)
            {
                var a = context.Users.Where(a => a.Id == h.UserId).ToList();
                foreach (var g in a)
                {
                    var bh = ($"{famcontact.MobileNumber}  {h.FirstName}  {h.LastName} {g.MarritalStatus} {g.PanCardNumber}");
                    chandhu.Add(bh);
                }
            }
            return chandhu;
        }

        public List<string> GetAllUserdetailesByUser(string User)
        {
            throw new NotImplementedException();
        }

        //public List<string> GetAllUserdetailesByUser(string UserName)
        //{
        //    List<string> text = new List<string>();
        //    var Firstname = context.Users.Where(a => a.FirstName == UserName).FirstOrDefault();
        //    var gender = context.Genders.Where(a => a.Id == Firstname.GenderId).FirstOrDefault();
        //    var mareg = context.MarritalStatuses.Where(a => a.Id == Firstname.MarritalStatusId).ToList();
        //    text.Add ($" {gender} {mareg}");
        //    //text.Add(gender + );
        //  // var a =   "gender" + "mareg";
        //    foreach (var data in text )
        //    {
        //        var vamshi = ($"{data}");
        //    }


       

    }
}

