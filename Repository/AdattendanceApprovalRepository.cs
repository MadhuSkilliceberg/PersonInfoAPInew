using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    /// <summary>
    /// Repository class to handle CRUD operations for AdattendanceApproval entity asynchronously.
    /// </summary>
    public class AdattendanceApprovalRepository : IAdattendanceApprovalRepository
    {
        // Instance of the database context for accessing AdattendanceApproval data.
        private readonly PersonsInfoV3NewContext _context;

        public AdattendanceApprovalRepository(PersonsInfoV3NewContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Asynchronously deletes an AdattendanceApproval record by ID.
        /// </summary>
        /// <param name="id">The ID of the AdattendanceApproval record to be deleted.</param>
        /// <returns>A task representing the asynchronous operation, with the number of records affected by the delete operation as the result.</returns>
        public async Task<int> DeleteAdattendanceApprovalAsync(int id)
        {
            var adattendanceApproval = await _context.AdattendanceApprovals
                .Where(c => c.AttendanceApprovalId == id)
                .FirstOrDefaultAsync();

            if (adattendanceApproval != null)
            {
                _context.AdattendanceApprovals.Remove(adattendanceApproval);
                await _context.SaveChangesAsync();
            }

            return adattendanceApproval.AttendanceApprovalId; // Return success
        }

        /// <summary>
        /// Asynchronously retrieves an AdattendanceApproval entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the AdattendanceApproval.</param>
        /// <returns>A task representing the asynchronous operation, with the AdattendanceApproval entity that matches the given ID as the result.</returns>
        public async Task<AdattendanceApproval> GetByAdattendanceApprovalIdAsync(int id)
        {
            return await _context.AdattendanceApprovals
                .Where(c => c.AttendanceApprovalId == id)
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Asynchronously retrieves all AdattendanceApproval records from the database.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, with a list of AdattendanceApproval entities as the result.</returns>
        public async Task<List<AdattendanceApproval>> GetAdattendanceApprovalsAsync()
        {
            return await _context.AdattendanceApprovals.ToListAsync();
        }

        /// <summary>
        /// Asynchronously inserts a new AdattendanceApproval record into the database.
        /// </summary>
        /// <param name="adattendanceApproval">The AdattendanceApproval entity to be inserted.</param>
        /// <returns>A task representing the asynchronous operation, with the ID of the newly inserted AdattendanceApproval record as the result.</returns>
        public async Task<int> InsertAdattendanceApprovalAsync(AdattendanceApproval adattendanceApproval)
        {
            _context.AdattendanceApprovals.Add(adattendanceApproval);
            await _context.SaveChangesAsync();
            return adattendanceApproval.AttendanceApprovalId;
        }

        /// <summary>
        /// Asynchronously updates an existing AdattendanceApproval record in the database.
        /// </summary>
        /// <param name="adattendanceApproval">The AdattendanceApproval entity containing updated information.</param>
        /// <returns>A task representing the asynchronous operation, with a boolean value indicating if the update was successful.</returns>
        public async Task<bool> UpdateAdattendanceApprovalAsync(AdattendanceApproval adattendanceApproval)
        {
            _context.AdattendanceApprovals.Update(adattendanceApproval);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
