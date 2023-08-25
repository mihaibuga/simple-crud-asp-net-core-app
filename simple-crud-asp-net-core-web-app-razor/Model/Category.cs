using System.ComponentModel.DataAnnotations;

namespace simple_crud_asp_net_core_web_app_razor.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(0,100, ErrorMessage = "Display Order must be in range of 1 to 100.")]
        public int DisplayOrder { get; set; }
    }
}