using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PersonsInfoV2Api.Controllers
{
    //[Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class AdattendanceApprovalController : ControllerBase
    {
        private readonly IAdattendanceApprovalBusinessLogic _adattendanceApprovalBusinessLogic;

        public AdattendanceApprovalController(IAdattendanceApprovalBusinessLogic adattendanceApprovalBusinessLogic)
        {
            _adattendanceApprovalBusinessLogic = adattendanceApprovalBusinessLogic;
        }

        /// <summary>
        /// Asynchronously deletes an AdattendanceApproval record by ID.
        /// </summary>
        /// <param name="id">The ID of the AdattendanceApproval record to be deleted.</param>
        /// <returns>An IActionResult indicating the result of the operation.</returns>
        [Route("DeleteAdattendanceApproval/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAdattendanceApprovalAsync(int id)
        {
            var result = await _adattendanceApprovalBusinessLogic.DeleteAdattendanceApprovalAsync(id);
            return Convert.ToBoolean(result) ? Ok() : NotFound();
        }

        /// <summary>
        /// Asynchronously retrieves an AdattendanceApproval entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the AdattendanceApproval.</param>
        /// <returns>An IActionResult with the AdattendanceApproval entity or NotFound if not found.</returns>
        [Route("GetAdattendanceApprovalById/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetByAdattendanceApprovalIdAsync(int id)
        {
            var adattendanceApproval = await _adattendanceApprovalBusinessLogic.GetByAdattendanceApprovalIdAsync(id);
            return adattendanceApproval != null ? Ok(adattendanceApproval) : NotFound();
        }

        /// <summary>
        /// Asynchronously retrieves all AdattendanceApproval records from the database.
        /// </summary>
        /// <returns>An IActionResult with a list of AdattendanceApproval entities.</returns>
        [Route("GetAdattendanceApprovals")]
        [HttpGet]
        public async Task<IActionResult> GetAdattendanceApprovalsAsync()
        {
            var adattendanceApprovals = await _adattendanceApprovalBusinessLogic.GetAdattendanceApprovalsAsync();
            return Ok(adattendanceApprovals);
        }

        /// <summary>
        /// Asynchronously inserts a new AdattendanceApproval record into the database.
        /// </summary>
        /// <param name="adattendanceApproval">The AdattendanceApproval entity to be inserted.</param>
        /// <returns>An IActionResult with the ID of the newly inserted AdattendanceApproval record.</returns>
        [Route("AddAdattendanceApproval")]
        [HttpPost]
        public async Task<IActionResult> InsertAdattendanceApprovalAsync([FromBody] AdattendanceApproval adattendanceApproval)
        {
            if (adattendanceApproval == null)
            {
                return BadRequest("AdattendanceApproval cannot be null.");
            }

            var id = await _adattendanceApprovalBusinessLogic.InsertAdattendanceApprovalAsync(adattendanceApproval);
            return CreatedAtAction(nameof(GetByAdattendanceApprovalIdAsync), new { id = id }, id);
        }

        /// <summary>
        /// Asynchronously updates an existing AdattendanceApproval record in the database.
        /// </summary>
        /// <param name="adattendanceApproval">The AdattendanceApproval entity containing updated information.</param>
        /// <returns>An IActionResult indicating the result of the operation.</returns>
        [Route("UpdateAdattendanceApproval")]
        [HttpPut]
        public async Task<IActionResult> UpdateAdattendanceApprovalAsync([FromBody] AdattendanceApproval adattendanceApproval)
        {
            if (adattendanceApproval == null)
            {
                return BadRequest("AdattendanceApproval cannot be null.");
            }

            var success = await _adattendanceApprovalBusinessLogic.UpdateAdattendanceApprovalAsync(adattendanceApproval);
            return success ? Ok() : NotFound();
        }
    }
}
