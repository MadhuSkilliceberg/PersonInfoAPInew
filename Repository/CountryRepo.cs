using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class CountryRepo : ICountryRepo
    {


        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        public int DeleteUser(int id)
        {
            var k = Context.Countries.Where(a => a.Id == id).FirstOrDefault();
            Context.Countries.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Country GetByUserId(int id)
        {
            var k = Context.Countries.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }


        public List<Country> GetCountries()
        {
            List<Country> Countries = new List<Country>();
            Country country1 = new Country();
            try
            {


                SqlConnection con = new SqlConnection("Server=DESKTOP-NGLPT1P\\SQLEXPRESS;Database=PersonsInfo;Trusted_Connection=True");
                {
                    SqlCommand cmd = new SqlCommand("Select * from Countries", con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Country country = new Country()
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            Name = rdr["Name"].ToString(),
                            Code = rdr["Code"].ToString(),

                        };
                        Countries.Add(country);
                        rdr.Close();
                        con.Close();
                    }
                }
            }

            catch (Exception ex)
            {

                return Countries;
            }

            return Countries;


        }





        public List<Country> GetUsers()
        {
            return Context.Countries.ToList();
        }

        public bool InsertUser(Country user)
        {

            Context.Countries.Add(user);
            Context.SaveChanges();
            return true;
        }

        public int InsertUserADO(Country user)
        {
           Context.Countries.Add(user);


            try
            {


                SqlConnection con = new SqlConnection("Server=DESKTOP-NGLPT1P\\SQLEXPRESS;Database=PersonsInfo;Trusted_Connection=True");
                {
                    SqlCommand cmd = new SqlCommand("insert into Countries values(6,'Switzerland','SWZ');", con);
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Country country = new Country()
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            Name = rdr["Name"].ToString(),
                            Code = rdr["Code"].ToString(),

                        };
                        Context.Add(con);
                        rdr.Close();
                        con.Close();
                    }
                }
            }

            catch (Exception ex)
            {

                return user.Id;
            }

            return user.Id;





        }

        public bool UpdateUser(Country user)
        {
            Context.Countries.Update(user);
            Context.SaveChanges();
            return true;
        }
    }
}
