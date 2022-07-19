using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class FileFormatMap : ClassMap<FileUploadDTO>
    {
        public FileFormatMap()
        {
            //Map(m => m.Id).Convert(row => row.Row.Context.Parser.RawRow);
            //Map(m => m.Identity).Name("Identity");
            //Map(m => m.FirstName).Name("FirstName");
            //Map(m => m.Surname).Name("Surname");
            //Map(m => m.Age).Name("Age");
            //Map(m => m.Sex).Name("Sex");
            //Map(m => m.Mobile).Name("Mobile");
            //Map(m => m.Active).Name("Active");

        }
    }
}
