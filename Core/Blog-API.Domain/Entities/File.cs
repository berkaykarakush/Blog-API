using Blog_API.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_API.Domain.Entities
{
    public class File : BaseEntity
    {
        // The name of the file
        public string FileName { get; set; }
        
        // The path to the file
        public string Path { get; set; }

        // The storage information for the file
        public string Storage { get; set; }

        //This property is not mapped to the database and overrides the base class's UpdatedDate property
        [NotMapped]
        public override DateTime UpdatedDate { get => base.UpdatedDate; set => base.UpdatedDate = value; }
    }
}
