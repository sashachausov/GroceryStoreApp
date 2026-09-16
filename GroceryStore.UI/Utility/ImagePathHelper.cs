using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.UI.Utility
{
    public static class ImagePathHelper
    {
        public const string DefaultCategoryImagePath = "Images/System/DefaultImage.png";

        public static string GetAbsolutePath(string relativePath)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath.Replace("/", Path.DirectorySeparatorChar.ToString()));
        }

        public static string GetCategoryDisplayImagePath(string? categoryImagePath)
        {
            var relativePath = string.IsNullOrWhiteSpace(categoryImagePath) ? DefaultCategoryImagePath : categoryImagePath;
            return GetAbsolutePath(relativePath);
        }

        public static string CopyCategoryImageToAppFolder(string sourceFilePath)
        {
            if (string.IsNullOrWhiteSpace(sourceFilePath))
                throw new ArgumentException("Image path is empty.");

            if (!File.Exists(sourceFilePath))
                throw new FileNotFoundException("Selected image file was not found.");

            var imagesFolder = GetAbsolutePath("Images/Categories");
            Directory.CreateDirectory(imagesFolder);

            var extension = Path.GetExtension(sourceFilePath);
            var fileName = $"{Guid.NewGuid()}{extension}";
            var destinationPath = Path.Combine(imagesFolder, fileName);

            File.Copy(sourceFilePath, destinationPath, overwrite: false);
            return $"Images/Categories/{fileName}";
        }
    }
}
