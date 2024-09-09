using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    /// <summary>
    /// Interface for AdattendanceApproval repository to define methods for CRUD operations on AdattendanceApproval entities.
    /// </summary>
    public interface IAdattendanceApprovalRepository
    {
        /// <summary>
        /// Retrieves all AdattendanceApproval records from the database asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of AdattendanceApproval entities.</returns>
        public Task<List<AdattendanceApproval>> GetAdattendanceApprovalsAsync();

        /// <summary>
        /// Inserts a new AdattendanceApproval record into the database asynchronously.
        /// </summary>
        /// <param name="adattendanceApproval">The AdattendanceApproval entity to be inserted.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the ID of the newly inserted AdattendanceApproval record.</returns>
        public Task<int> InsertAdattendanceApprovalAsync(AdattendanceApproval adattendanceApproval);

        /// <summary>
        /// Updates an existing AdattendanceApproval record in the database asynchronously.
        /// </summary>
        /// <param name="adattendanceApproval">The AdattendanceApproval entity containing updated information.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean value indicating whether the update was successful.</returns>
        public Task<bool> UpdateAdattendanceApprovalAsync(AdattendanceApproval adattendanceApproval);

        /// <summary>
        /// Deletes an AdattendanceApproval record from the database by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the AdattendanceApproval record to be deleted.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the number of records affected by the delete operation.</returns>
        public Task<int> DeleteAdattendanceApprovalAsync(int id);

        /// <summary>
        /// Retrieves a single AdattendanceApproval record by its ID asynchronously.
        /// </summary>
        /// <param name="id">The ID of the AdattendanceApproval record to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the AdattendanceApproval entity that matches the given ID.</returns>
        public Task<AdattendanceApproval> GetByAdattendanceApprovalIdAsync(int id);
    }
}
