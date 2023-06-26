using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateBlazorApp.Shared.ViewModels
{
    public class FileUploadResponse
    {
        public string UploadFile { get; set; } = default!;
        public string UploadFileName { get; set; } = default!;
    }
}
