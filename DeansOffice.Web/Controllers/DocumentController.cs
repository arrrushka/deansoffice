using DeansOffice.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeansOffice.Web.Controllers
{
    [Route("api/[controller]")]
    public class DocumentController : Controller
    {
        private IDocumentService documentService;

        public DocumentController(IDocumentService documentService)
        {
            this.documentService = documentService;
        }

        public IActionResult GetById(long documentId)
        {
            return Ok(documentService.GetById(documentId));
        }

        public IActionResult GetByRequestId(long requestId)
        {
            return Ok(documentService.GetByRequestId(requestId));
        }

        public IActionResult GetMyAllDocuments()
        {
            long studentId = 0; // Найти способ получить текущего пользователя

            return Ok(documentService.GetByStudentId(studentId));
        }
    }
}
