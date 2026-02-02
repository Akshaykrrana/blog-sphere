using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSphere.Models
{
    public class Post
    {
        /// <summary>
        /// Id of the Post
        /// </summary>
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// Title of the Post
        /// </summary>
        [Required(ErrorMessage = "The Title is Required")]
        [MaxLength(400, ErrorMessage = "The Title cannot exceed 400 characters")]
        public string Title { get; set; }

        /// <summary>
        /// Post content
        /// </summary>
        [Required(ErrorMessage = "The Content is Required")]
        public string Content { get; set; }

        /// <summary>
        /// Author name detail
        /// </summary>
        [Required(ErrorMessage = "The Content is Required")]
        [MaxLength(100, ErrorMessage = "The Name cannot exceed 100 characters")]
        public string Author { get; set; }

        /// <summary>
        /// Path of the Image
        /// </summary>
        public string FeatureImagePath { get; set; }

        /// <summary>
        /// Post Published Date
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Id of the Category
        /// </summary>
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Navigation Property from Category Table
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Navigation Propery from Comment Table
        /// </summary>
        public ICollection<Comment> comments { get; set; }
    }
}
