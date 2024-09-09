using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    /// <summary>
    /// Interface for AdAttendance repository to define methods for CRUD operations on AdAttendance entities.
    /// </summary>
    public interface IAdAttendanceRepository
    {
        /// <summary>
        /// Retrieves all AdAttendance records from the database asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of AdAttendance entities.</returns>
        public Task<List<Adattendance>> GetAdAttendancesAsync();

        /// <summary>
        /// Inserts a new AdAttendance record into the database asynchronously.
        /// </summary>
        /// <param name="adAttendance">The AdAttendance entity to be inserted.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the ID of the newly inserted AdAttendance record.</returns>
        public Task<int> InsertAdAttendanceAsync(Adattendance adAttendance);

        /// <summary>
        /// Updates an existing AdAttendance record in the database asynchronously.
        /// </summary>
        /// <param name="adAttendance">The AdAttendance entity containing updated information.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean value indicating whether the update was successful.</returns>
        public Task<bool> UpdateAdAttendanceAsync(Adattendance adAttendance);

        /// <summary>
        /// Deletes an AdAttendance record from the database by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the AdAttendance record to be deleted.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the number of records affected by the delete operation.</returns>
        public Task<int> DeleteAdAttendanceAsync(int id);

        /// <summary>
        /// Retrieves a single AdAttendance record by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the AdAttendance record to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the AdAttendance entity that matches the given ID.</returns>
        public Task<Adattendance> GetByAdAttendanceIdAsync(int id);
    }
}
