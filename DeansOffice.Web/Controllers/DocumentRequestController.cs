using DeansOffice.Logic.DTOs;
using DeansOffice.Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeansOffice.Web.Controllers
{
    [Route("api/[controller]")]
    public class DocumentRequestController : Controller
    {
        private IDocumentRequestService documentRequestService;

        public DocumentRequestController(IDocumentRequestService documentRequestService)
        {
            this.documentRequestService = documentRequestService;
        }

        public IActionResult NewRequest(NewRequestDTO requestDTO)
        {
            documentRequestService.Save(requestDTO);
            return Ok();
        }

        public IActionResult Approve(NewDocumentDTO newDocument)
        {
            return Ok(documentRequestService.Approve(newDocument));
        }

        public IActionResult Deny(long requestId)
        {
            documentRequestService.Deny(requestId);
            return Ok();
        }
    }
}
