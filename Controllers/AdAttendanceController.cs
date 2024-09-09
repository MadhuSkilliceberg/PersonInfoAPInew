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
    public class AdAttendanceController : ControllerBase
    {
        private readonly IAdAttendanceBusinessLogic _adAttendanceBusinessLogic;

        public AdAttendanceController(IAdAttendanceBusinessLogic adAttendanceBusinessLogic)
        {
            _adAttendanceBusinessLogic = adAttendanceBusinessLogic;
        }

        /// <summary>
        /// Asynchronously deletes an AdAttendance record by ID.
        /// </summary>
        /// <param name="id">The ID of the AdAttendance record to be deleted.</param>
        /// <returns>An IActionResult indicating the result of the operation.</returns>
        [Route("DeleteAdAttendances/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAdAttendanceAsync(int id)
        {
            var result = await _adAttendanceBusinessLogic.DeleteAdAttendanceAsync(id);
            return Convert.ToBoolean(result) ? Ok() : NotFound();
        }

        /// <summary>
        /// Asynchronously retrieves an AdAttendance entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the AdAttendance.</param>
        /// <returns>An IActionResult with the AdAttendance entity or NotFound if not found.</returns>
        [Route("GetAdAttendanceById/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetByAdAttendanceIdAsync(int id)
        {
            var adAttendance = await _adAttendanceBusinessLogic.GetByAdAttendanceIdAsync(id);
            return adAttendance != null ? Ok(adAttendance) : NotFound();
        }

        /// <summary>
        /// Asynchronously retrieves all AdAttendance records from the database.
        /// </summary>
        /// <returns>An IActionResult with a list of AdAttendance entities.</returns>
        [Route("GetAdAttendances")]
        [HttpGet]
        public async Task<IActionResult> GetAdAttendancesAsync()
        {
            var adAttendances = await _adAttendanceBusinessLogic.GetAdAttendancesAsync();
            return Ok(adAttendances);
        }

        /// <summary>
        /// Asynchronously inserts a new AdAttendance record into the database.
        /// </summary>
        /// <param name="adAttendance">The AdAttendance entity to be inserted.</param>
        /// <returns>An IActionResult with the ID of the newly inserted AdAttendance record.</returns>
        [Route("AddAdAttendance")]
        [HttpPost]
        public async Task<IActionResult> InsertAdAttendanceAsync([FromBody] Adattendance adAttendance)
        {
            if (adAttendance == null)
            {
                return BadRequest("AdAttendance cannot be null.");
            }

            var id = await _adAttendanceBusinessLogic.InsertAdAttendanceAsync(adAttendance);
            return CreatedAtAction(nameof(GetByAdAttendanceIdAsync), new { id = id }, id);
        }

        /// <summary>
        /// Asynchronously updates an existing AdAttendance record in the database.
        /// </summary>
        /// <param name="adAttendance">The AdAttendance entity containing updated information.</param>
        /// <returns>An IActionResult indicating the result of the operation.</returns>
        [Route("UpdateAdAttendance")]
        [HttpPut]
        public async Task<IActionResult> UpdateAdAttendanceAsync([FromBody] Adattendance adAttendance)
        {
            if (adAttendance == null)
            {
                return BadRequest("AdAttendance cannot be null.");
            }

            var success = await _adAttendanceBusinessLogic.UpdateAdAttendanceAsync(adAttendance);
            return success ? Ok() : NotFound();
        }
    }
}
