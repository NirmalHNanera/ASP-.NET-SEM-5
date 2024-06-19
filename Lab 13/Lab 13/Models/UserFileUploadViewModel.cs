using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab_13.Models
{
    public class UserFileUploadViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public List<IFormFile> Files { get; set; }

        public List<FileDetail> UploadedFiles { get; set; } = new List<FileDetail>();
    }

    public class FileDetail
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}