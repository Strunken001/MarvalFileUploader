using Application.Queries.Files.UploadFile;
using Application.Queries.Files.ValidateFile;
using Domain.Entities;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class FileUploadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FileUploadController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<List<FileToUpload>>> GetFileCompareResult(List<FileUploadDTO> request)
        {

            var result = await _mediator.Send(new UploadFileContentCommand(request));

            return Ok(result);
        }

    }
}
