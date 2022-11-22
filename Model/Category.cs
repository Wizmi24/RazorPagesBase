using System.ComponentModel.DataAnnotations;

namespace RazorPagesBase.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="Display Order")]
        [Range(1, 100, ErrorMessage ="The range must be within range 1-100")]
        public int DisplaOrder { get; set; }
    }
}
