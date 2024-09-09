using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    /// <summary>
    /// Business logic class to handle AdattendanceApproval-related operations.
    /// This class uses the repository layer to perform data access and applies business rules.
    /// </summary>
    public class AdattendanceApprovalBusinessLogic : IAdattendanceApprovalBusinessLogic
    {
        // Reference to the AdattendanceApproval repository for data operations.
        private readonly IAdattendanceApprovalRepository adattendanceApprovalRepository;

        /// <summary>   
        /// Constructor to inject the repository dependency for AdattendanceApproval.
        /// </summary>
        /// <param name="adattendanceApprovalRepository">The repository handling AdattendanceApproval data access.</param>
        public AdattendanceApprovalBusinessLogic(IAdattendanceApprovalRepository adattendanceApprovalRepository)
        {
            this.adattendanceApprovalRepository = adattendanceApprovalRepository;
        }

        /// <summary>
        /// Deletes an AdattendanceApproval record by its ID.
        /// </summary>
        /// <param name="id">The ID of the AdattendanceApproval to be deleted.</param>
        /// <returns>The number of records affected by the delete operation.</returns>
        public async Task<int> DeleteAdattendanceApprovalAsync(int id)
        {
            return await adattendanceApprovalRepository.DeleteAdattendanceApprovalAsync(id);
        }

        /// <summary>
        /// Retrieves all AdattendanceApproval records.
        /// </summary>
        /// <returns>A list of all AdattendanceApproval records.</returns>
        public async Task<List<AdattendanceApproval>> GetAdattendanceApprovalsAsync()
        {
            return await adattendanceApprovalRepository.GetAdattendanceApprovalsAsync();
        }

        /// <summary>
        /// Retrieves a specific AdattendanceApproval record by its ID.
        /// </summary>
        /// <param name="id">The ID of the AdattendanceApproval to retrieve.</param>
        /// <returns>The AdattendanceApproval entity matching the given ID.</returns>
        public async Task<AdattendanceApproval> GetByAdattendanceApprovalIdAsync(int id)
        {
            return await adattendanceApprovalRepository.GetByAdattendanceApprovalIdAsync(id);
        }

        /// <summary>
        /// Inserts a new AdattendanceApproval record into the database.
        /// </summary>
        /// <param name="adattendanceApproval">The AdattendanceApproval entity to insert.</param>
        /// <returns>The ID of the newly inserted AdattendanceApproval record.</returns>
        public async Task<int> InsertAdattendanceApprovalAsync(AdattendanceApproval adattendanceApproval)
        {
            return await adattendanceApprovalRepository.InsertAdattendanceApprovalAsync(adattendanceApproval);
        }

        /// <summary>
        /// Updates an existing AdattendanceApproval record.
        /// </summary>
        /// <param name="adattendanceApproval">The AdattendanceApproval entity with updated information.</param>
        /// <returns>True if the update was successful, otherwise false.</returns>
        public async Task<bool> UpdateAdattendanceApprovalAsync(AdattendanceApproval adattendanceApproval)
        {
            return await adattendanceApprovalRepository.UpdateAdattendanceApprovalAsync(adattendanceApproval);
        }
    }
}
