using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    /// <summary>
    /// Repository class to handle CRUD operations for AdAttendance entity asynchronously.
    /// </summary>
    public class AdAttendanceRepository : IAdAttendanceRepository
    {
        // Instance of the database context for accessing AdAttendance data.
        private readonly PersonsInfoV3NewContext _context;

        public AdAttendanceRepository(PersonsInfoV3NewContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Asynchronously deletes an AdAttendance record by ID.
        /// </summary>
        /// <param name="id">The ID of the AdAttendance record to be deleted.</param>
        /// <returns>A task representing the asynchronous operation, with the number of records affected by the delete operation as the result.</returns>
        public async Task<int> DeleteAdAttendanceAsync(int id)
        {
            var adAttendance = await _context.Adattendances
                .Where(c => c.AttendanceId == id)
                .FirstOrDefaultAsync();

            if (adAttendance != null)
            {
                _context.Adattendances.Remove(adAttendance);
                await _context.SaveChangesAsync();
            }

            return adAttendance.AttendanceId; // Return success
        }

        /// <summary>
        /// Asynchronously retrieves an AdAttendance entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the AdAttendance.</param>
        /// <returns>A task representing the asynchronous operation, with the AdAttendance entity that matches the given ID as the result.</returns>
        public async Task<Adattendance> GetByAdAttendanceIdAsync(int id)
        {
            return await _context.Adattendances
                .Where(c => c.AttendanceId == id)
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Asynchronously retrieves all AdAttendance records from the database.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, with a list of AdAttendance entities as the result.</returns>
        public async Task<List<Adattendance>> GetAdAttendancesAsync()
        {
            return await _context.Adattendances.ToListAsync();
        }

        /// <summary>
        /// Asynchronously inserts a new AdAttendance record into the database.
        /// </summary>
        /// <param name="adAttendance">The AdAttendance entity to be inserted.</param>
        /// <returns>A task representing the asynchronous operation, with the ID of the newly inserted AdAttendance record as the result.</returns>
        public async Task<int> InsertAdAttendanceAsync(Adattendance adAttendance)
        {
            _context.Adattendances.Add(adAttendance);
            await _context.SaveChangesAsync();
            return adAttendance.AttendanceId;
        }

        /// <summary>
        /// Asynchronously updates an existing AdAttendance record in the database.
        /// </summary>
        /// <param name="adAttendance">The AdAttendance entity containing updated information.</param>
        /// <returns>A task representing the asynchronous operation, with a boolean value indicating if the update was successful.</returns>
        public async Task<bool> UpdateAdAttendanceAsync(Adattendance adAttendance)
        {
            _context.Adattendances.Update(adAttendance);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
