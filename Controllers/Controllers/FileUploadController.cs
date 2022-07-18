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
        public async Task<ActionResult<FileValidateResultVm>> GetFileCompareResult([FromForm] UploadFileCompareQuery getFilesCompareQuery)
        {

            var compareFileResultVm = await _mediator.Send(getFilesCompareQuery);

            return Ok(compareFileResultVm);
        }

    }
}
