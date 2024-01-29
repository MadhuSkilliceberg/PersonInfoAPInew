using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfoV2Api.Repository
{
    public class CoutryStateRepository: ICoutryStateRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteUser(int id)
        {
            var k = Context.CoutryStates.Where(a => a.Id == id).FirstOrDefault();
            Context.CoutryStates.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        //public CoutryState GetByUserId(CoutryState coutryState)
        //{
        //    List<CoutryState> CoutryStates = new List<CoutryState>();

        //    var CoutryState = Context.CoutryStates.Where(a => a.Id == coutryState.Id).FirstOrDefault();
            //foreach (var u in CoutryStates)
            //    if (coutryState == CoutryStates.)
            //{

            //}


            //foreach (var u in CoutryStates)
            //{
            //    if (coutryState == u.CountryId)
            //    {
            //        u.Country;
            //    }
            //    else if (u.State == u.State)
            //    {
            //        return u.Country;

            //    }
            //    else
            //    {
            //        return "state or country not matched.";
            //    }
            //}




           

            //return CoutryState;
        //}

        //public List<CoutryState> GetUsers( string countrymname)
        //{
        //    List<CoutryState> CoutryStates = new List<CoutryState>();
        //    CoutryStates= Context.CoutryStates.ToList();
            //string c="c";
            //   string state;

            // if (Context.Countries.)

            //for (int i=0;i< CoutryStates.Count; i++)
            //{
            //    var vnay = CoutryStates[i].CountryId;
            //    var srikanth= CoutryStates[i].Country;

            //    var bhanu= CoutryStates[i].State;
            //    var chandu = CoutryStates[i].StateId;



            //   if (vnay == chandu)
            //   {

            //   }
            //    else if(srikanth == bhanu)
            //   {

            //   }

            //}

            //foreach (var u in coutrystates)
            //{
            //    if (u.stateid == u.countryid)
            //    {
            //        u.country;
            //    }
            //    else if (state == u.state)
            //    {
            //        return u.country;

            //    }
            //    else
            //    {
            //        return "state or country not matched.";
            //    }
            //}

        //    return CoutryStates;
        //}  

        public int InsertUser(CoutryState user)
        {
            Context.CoutryStates.Add(user);
            Context.SaveChanges();
            return user.Id;
        }

        public bool UpdateUser(CoutryState user)
        {
            Context.CoutryStates.Update(user);
            Context.SaveChanges();
            return true;
        }

       public  CoutryState GetByUserId(int id)
        {
            var l = Context.CoutryStates.Where(a => a.Id == id).FirstOrDefault();
            return l;
        }

        public  List<CoutryState> GetUsers()
        {
            return Context.CoutryStates.ToList();
        }

         public  List<string> GetByCountryStates(string statename)
        {
            List<string> Lost = new List<string>();
            var statedata = Context.States.Where(t => t.Name == statename).FirstOrDefault();
            var countrystatedata = Context.CoutryStates.Where(a => a.StateId == statedata.Id).ToList();

            foreach(var data in countrystatedata)
            {
                var countrys = Context.Countries.Where(a => a.Id == data.CountryId).ToList();

                foreach (var cs in countrys)
                {
                    var a = ($"{statedata.Name} {statedata.Code} {cs.Name} {cs.Code}");

                    Lost.Add(a);
                }
                // var a = ($"{data.StateId} {data.CountryId}");
                //Lost.Add(a);

            }
            return Lost;
        }


        public List<string> GetByStatesCountry(string countryname)
        { 
           

            List<string> state = new List<string>();
            var countrydata = Context.Countries.Where(s => s.Name == countryname).FirstOrDefault();
            var countrystatedata = Context.CoutryStates.Where(t => t.CountryId == countrydata.Id).ToList();
            
            foreach (var data in countrystatedata)
            {
                var states = Context.States.Where(a => a.Id == data.StateId).ToList();

                foreach (var cs in states)
                {
                    var a = ($"{countrydata.Name} {countrydata.Code} {cs.Name} {cs.Code}");

                    state.Add(a);
                    state.Count();
                }
               
            }
            return state;
        }

        //public List<CoutryState> GetCoutryStates()
        //{
        //    return Context.CoutryStates.ToList();
        //}

        //public List<string> GetByCountryStates(string statename)
        //{
        //    List<string> country = new List<string>();
        //    var statedata = Context.States.Where(t => t.StateName == statename).FirstOrDefault();
        //    var countrystatedata = Context.CoutryStates.Where(a => a.StateId == statedata.Id).ToList();

        //    foreach (var data in countrystatedata)
        //    {
        //        var countrys = Context.Countries.Where(a => a.Id == data.CountryId).ToList();

        //        foreach (var cs in countrys)
        //        {
        //            var a = ($"{statedata.StateName} {statedata.Code} {cs.CountryName} {cs.Code}");

        //            country.Add(a);
        //        }


        //    }
        //    return country;
        //}


        //public List<string> GetByStatesCountry(string countryname)
        //{
        //    List<string> state = new List<string>();
        //    var countrydata = Context.Countries.Where(s => s.CountryName == countryname).FirstOrDefault();
        //    var countrystatedata = Context.CoutryStates.Where(t => t.CountryId == countrydata.Id).ToList();

        //    foreach (var data in countrystatedata)
        //    {
        //        var states = Context.States.Where(a => a.Id == data.StateId).ToList();

        //        foreach (var cs in states)
        //        {
        //            var a = ($"{countrydata.CountryName} {countrydata.Code} {cs.StateName} {cs.Code}");

        //            state.Add(a);
        //        }

        //    }
        //    return state;
        //}


    }
}
