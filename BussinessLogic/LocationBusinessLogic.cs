using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class LocationBusinessLogic: ILocationBusinessLogic
    {
        ILocationRepo LocationRepo;

        public  LocationBusinessLogic(ILocationRepo Repo)
        {
            LocationRepo = Repo;
        }

        public int DeleteLocation(int id)
        {
            return LocationRepo.DeleteLocation(id);
        }

        public Location GetByLocationId(int id)
        {
            return LocationRepo.GetByLocationId(id);
        }

        public List<Location> GetLocations()
        {
            return LocationRepo.GetLocations();
        }

        public int InsertLocation(Location Location)
        {
            return LocationRepo.InsertLocation(Location);
        }

        public bool UpdateLocation(Location Location)
        {
            return LocationRepo.UpdateLocation(Location);
        }
    }
}
