using Application.Queries.Files.UploadFile;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Files.ValidateFile
{
    public class GetFileCompareValidator: AbstractValidator<UploadFileCompareQuery>
    {
        public GetFileCompareValidator()
        {
            RuleFor(p => p.file)
                .NotNull().WithMessage("{PropertyName} is required.");

        }
    }
}
