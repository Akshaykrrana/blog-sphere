using System.ComponentModel.DataAnnotations;

namespace BlogSphere.Models
{
    public class Category
    {
        /// <summary>
        /// Id of the Category
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the Category
        /// </summary>
        [Required(ErrorMessage = "The Category name is Required")]
        [MaxLength(200, ErrorMessage = "Category name cannot exceed 200 characters")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the Category
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Navigation Property from Post Table
        /// </summary>
        public ICollection<Post> Posts { get; set; } 
    }
}
