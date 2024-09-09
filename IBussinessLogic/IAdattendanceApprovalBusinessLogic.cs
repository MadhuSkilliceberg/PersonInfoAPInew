using PersonsInfoV2Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
    public interface IAdattendanceApprovalBusinessLogic
    {
        /// <summary>
        /// Retrieves all AdAttendance records from the database asynchronously.
        /// This method is responsible for business logic to retrieve and process all attendance records.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of AdAttendance entities.</returns>
        public Task<List<AdattendanceApproval>> GetAdattendanceApprovalsAsync();

        /// <summary>
        /// Inserts a new AdAttendance record into the database asynchronously.
        /// This method handles validation and business rules for inserting new attendance records.
        /// </summary>
        /// <param name="adAttendance">The AdAttendance entity to be inserted.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the ID of the newly inserted AdAttendance record.</returns>
        public Task<int> InsertAdattendanceApprovalAsync(AdattendanceApproval adAttendance);

        /// <summary>
        /// Updates an existing AdAttendance record in the database asynchronously.
        /// This method applies business rules for updating attendance records.
        /// </summary>
        /// <param name="adAttendance">The AdAttendance entity containing updated information.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean value indicating whether the update was successful.</returns>
        public Task<bool> UpdateAdattendanceApprovalAsync(AdattendanceApproval adAttendance);

        /// <summary>
        /// Deletes an AdAttendance record from the database by its ID asynchronously.
        /// This method ensures business logic compliance before allowing the deletion of a record.
        /// </summary>
        /// <param name="id">The ID of the AdAttendance record to be deleted.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the number of records affected by the delete operation.</returns>
        public Task<int> DeleteAdattendanceApprovalAsync(int id);

        /// <summary>
        /// Retrieves a single AdAttendance record by its ID asynchronously.
        /// This method applies business logic to retrieve a specific attendance record by its ID.
        /// </summary>
        /// <param name="id">The ID of the AdAttendance record to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the AdAttendance entity that matches the given ID.</returns>
        public Task<AdattendanceApproval> GetByAdattendanceApprovalIdAsync(int id);
    }
}
