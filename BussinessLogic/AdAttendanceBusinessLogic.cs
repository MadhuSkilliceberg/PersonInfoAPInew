using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class AdAttendanceBusinessLogic : IAdAttendanceBusinessLogic
    {
        private readonly IAdAttendanceRepository adAttendanceRepository;
        private readonly IAdattendanceApprovalRepository adAttendanceApprovalRepository;
        private readonly IUserRepository userRepository;

        public AdAttendanceBusinessLogic(
            IAdAttendanceRepository adAttendanceRepository,
            IAdattendanceApprovalRepository adAttendanceApprovalRepository,
            IUserRepository userRepository
        )
        {
            this.adAttendanceRepository = adAttendanceRepository;
            this.adAttendanceApprovalRepository = adAttendanceApprovalRepository;
            this.userRepository = userRepository;
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

        public async Task<User> GetUserAttendanceApprovalByUserId(int loggedUserId)
        {
            List<AdattendanceApproval> adAttendanceApprovals = await adAttendanceApprovalRepository.GetAdattendanceApprovalsAsync();
            AdattendanceApproval adattendanceApproval = adAttendanceApprovals.FirstOrDefault(aa => aa.UserId == loggedUserId);
            if (adattendanceApproval != null)
            {
                return userRepository.GetByUserId(adattendanceApproval.UserParentId ?? 0);
            }
            else
            {
                User user = userRepository.GetByUserId(loggedUserId);
                if (user != null)
                {
                    return userRepository.GetByUserId(user.ParentId ?? 0);
                }
            }
            return new User();
        }

        public async Task<int> InsertAdAttendanceAsync(Adattendance adAttendance)
        {
            Adattendance submittedAdattendance = await adAttendanceRepository.InsertAdAttendanceAsync(adAttendance);
            if (submittedAdattendance != null)
            {
                AdattendanceApproval attendanceApproval = new AdattendanceApproval()
                {
                    AttendanceId = submittedAdattendance.AttendanceId,
                    Status = 0,
                    UserId = submittedAdattendance.UserId,
                    CreatedOn = DateTime.Now,
                    CreatedBy = submittedAdattendance.UserId
                };
                await adAttendanceApprovalRepository.InsertAdattendanceApprovalAsync(attendanceApproval);
                return submittedAdattendance.AttendanceId;
            }
            return 0;
        }

        public async Task<bool> UpdateAdAttendanceAsync(Adattendance adAttendance)
        {
            return await adAttendanceRepository.UpdateAdAttendanceAsync(adAttendance);
        }
    }
}
