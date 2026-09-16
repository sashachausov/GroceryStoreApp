using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GroceryStore.Domain.Entities
{
    public class Category
    {
        [JsonInclude]
        public Guid Id { get; private set; }
        [JsonInclude]
        public string Name { get; private set; } = string.Empty;
        [JsonInclude]
        public string? ImagePath { get; private set; }
        [JsonInclude]
        public bool IsActive { get; private set; }

        public Category() 
        { 
            
        }

        public Category(string name, string? imagePath = null)
        {
            Id = Guid.NewGuid();
            SetName(name);
            SetImagePath(imagePath);
            IsActive = true;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("Category name cannot be empty.");
            Name = name.Trim();
        }

        public void SetImagePath(string? imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                ImagePath = null;
                return;
            }

            ImagePath = NormalizeRelativePath(imagePath);
        }

        public void RemoveImage()
        {
            ImagePath = null;
        }

        public void Activate()
        {
            IsActive = true;
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    
        private static string NormalizeRelativePath(string path)
        {
            return path.Trim().Replace("\\", "/");
        }
    }
}
