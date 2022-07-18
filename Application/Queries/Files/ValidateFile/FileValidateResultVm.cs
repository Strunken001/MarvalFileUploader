using Domain.Models;
using Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Files.ValidateFile
{
    public class FileValidateResultVm : BaseResponse
    {
        public FileValidateResultVm() : base()
        {

        }

        public List<FileCompareDto> fileCompareDtos { get; set; } = new List<FileCompareDto>();

    }
}
