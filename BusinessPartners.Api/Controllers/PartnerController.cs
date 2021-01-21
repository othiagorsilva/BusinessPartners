using Microsoft.AspNetCore.Mvc;
using BusinessPartners.Domain.Services;
using BusinessPartners.Api.ViewModels;

namespace BusinessPartners.Api.Controllers
{
    public class PartnerController : Controller
    {
        private readonly IPartnerService _partnerService;

        public PartnerController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        [Route("v1/partners")]
        [HttpPost]
        public IActionResult Post([FromBody]PartnerViewModel newPartner)
        {
            try
            {
                _partnerService.Add(newPartner.Name, newPartner.BusinessName, newPartner.BusinessNumber);
                return StatusCode(201);
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}