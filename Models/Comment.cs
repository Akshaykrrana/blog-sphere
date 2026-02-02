using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace BlogSphere.Models
{
    public class Comment
    {
        /// <summary>
        /// Id of the Comment
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the user
        /// </summary>
        [Required(ErrorMessage = "The UserName is Required")]
        [MaxLength(100, ErrorMessage = "UserName cannot exceed 100 characters")]
        public string UserName { get; set; }

        /// <summary>
        /// Comment Date
        /// </summary>
        [DataType(DataType.Date)]
        public string CommentDate { get; set; }

        /// <summary>
        /// Context
        /// </summary>
        [Required]
        public string Context { get; set; }

        /// <summary>
        /// Id of the Post
        /// </summary>
        [ForeignKey("Post")]
        public int PostId { get; set; }

        /// <summary>
        /// Navigation Property from Post Table
        /// </summary>
        public Post Post { get; set; }
    }
}
