using Microsoft.AspNetCore.Http;

namespace School.Application.Common.Extensions
{
    public static class ImageExtension
    {
        public static bool CheckImageExtension(this IFormFile file)
        {
            var allowedExtensions = new[] { ".png", ".jpg", ".gif" };
            var extension = Path.GetExtension(file.FileName);
            if (string.IsNullOrEmpty(extension) || !allowedExtensions.Contains(extension.ToLower()))
                return false;
            return true;
        }

        public static bool CheckSizeExtension(this IFormFile file)
        {
            if (file.Length > 2 / 1024 * 1024)
                return false;
            return true;
        }
    }
}
