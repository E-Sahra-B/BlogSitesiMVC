using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace UI.Areas.Writer.Models
{
    public class AddProfileImage
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
        //public void ImageAdd(IFormFile image, out string fileName)
        //{
        //    var extension = Path.GetExtension(image.FileName);
        //    var newImageName = Guid.NewGuid() + extension;
        //    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
        //    var stream = new FileStream(location, FileMode.Create);
        //    image.CopyTo(stream);
        //    fileName = image.FileName;
        //}
    }
}
