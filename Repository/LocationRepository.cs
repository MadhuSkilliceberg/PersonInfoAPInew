using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class LocationRepository : ILocationRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteLocation(int id)
        {
            var a = person.Locations.Where(c => c.Id == id).FirstOrDefault();
            person.Locations.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Location GetByLocationId(int id)
        {
            return person.Locations.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Location> GetLocations()
        {
            return person.Locations.ToList();
        }

        public int InsertLocation(Location Location)
        {
            person.Locations.Add(Location);
            person.SaveChanges();
            return Location.Id;

        }

        public bool UpdateLocation(Location Location)
        {
            person.Locations.Update(Location);
            person.SaveChanges();
            return true;
        }
    }
}
