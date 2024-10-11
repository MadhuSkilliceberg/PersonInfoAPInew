using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using PersonsInfoV2Api.BussinessLogic;
using PersonsInfoV2Api.Models;

namespace PersonsInfoV2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsController : ControllerBase
    {
        private readonly EmailBusinessLogic _emailService;

        public SmsController(EmailBusinessLogic emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendSms([FromBody] SmsRequest request)
        {
            string carrierDomain = "airtel.in"; // Replace with appropriate carrier domain
            _emailService.SendSms(request.ToPhoneNumber, request.Message, carrierDomain);
            return Ok();
        }
    }
}
