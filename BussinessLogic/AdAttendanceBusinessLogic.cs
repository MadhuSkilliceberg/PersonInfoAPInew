using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class AdAttendanceBusinessLogic : IAdAttendanceBusinessLogic
    {
        private readonly IAdAttendanceRepository adAttendanceRepository;

        public AdAttendanceBusinessLogic(IAdAttendanceRepository adAttendanceRepository)
        {
            this.adAttendanceRepository = adAttendanceRepository;
        }
        public async Task<int> DeleteAdAttendanceAsync(int id)
        {
           return await adAttendanceRepository.DeleteAdAttendanceAsync(id);
        }

        public async Task<List<Adattendance>> GetAdAttendancesAsync()
        {
            return await adAttendanceRepository.GetAdAttendancesAsync();
        }

        public async Task<Adattendance> GetByAdAttendanceIdAsync(int id)
        {
            return await adAttendanceRepository.GetByAdAttendanceIdAsync(id);
        }

        public async Task<int> InsertAdAttendanceAsync(Adattendance adAttendance)
        {
           return await adAttendanceRepository.InsertAdAttendanceAsync(adAttendance);
        }

        public async Task<bool> UpdateAdAttendanceAsync(Adattendance adAttendance)
        {
            return await adAttendanceRepository.UpdateAdAttendanceAsync(adAttendance);
        }
    }
}
