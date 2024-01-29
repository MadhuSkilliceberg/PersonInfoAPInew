using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface ISprintRepo
    {
        public List<Sprint> GetSprints();
        public int InsertSprint(Sprint Sprint);

        public bool UpdateSprint(Sprint Sprint);

        public int DeleteSprint(int id);

        public Sprint GetBySprintId(int id);


    }
}
