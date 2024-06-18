using Microsoft.AspNetCore.Http;

namespace School.Application.Common.Models
{
    public class DocumentSettings
    {
        public static string UploadFiles(string relativePath, string folderName, IFormFile file)
        {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), relativePath, folderName);
            var fileName = $"{Guid.NewGuid()}{file.FileName}";
            var fullPath = Path.Combine(folderPath, fileName);

            using var fileStream = new FileStream(fullPath, FileMode.Create);

            file.CopyTo(fileStream);

            return fileName;
        }

        public static void DeleteFile(string relativePath, string folderName, string fileName)
        {
            if (fileName is not null && folderName is not null && relativePath is not null)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), relativePath, folderName, fileName);
                if (File.Exists(filePath))
                { File.Delete(filePath); }

            }
        }
    }
}
