using CsvHelper;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpers
{
    public static class FileHelper
    {
        public static List<FileUploadDTO> GetFileContent(IFormFile firstFile)
        {
            var fileContentResponse = new List<FileUploadDTO>();

            using (var streamReader = new StreamReader(firstFile.OpenReadStream()))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<FileFormatMap>();

                    fileContentResponse = csvReader.GetRecords<FileUploadDTO>().Distinct().ToList();

                }
            }

            return fileContentResponse;
        }


        //public static HashSet<FileFormat> RemoveDuplicate(List<FileFormat> contents)
        //{
        //    var filesContent = new HashSet<FileFormat>(new FileComparer());

        //    foreach (var item in contents)
        //    {

        //        filesContent.Add(item);

        //    }

        //    return filesContent;
        //}


    }

}
