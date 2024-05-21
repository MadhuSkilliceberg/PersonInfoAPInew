using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface ILocationRepo
    {
        public List<Location> GetLocations();
        public int InsertLocation(Location Location);

        public bool UpdateLocation(Location Location);

        public int DeleteLocation(int id);

        public Location GetByLocationId(int id);


    }
}
