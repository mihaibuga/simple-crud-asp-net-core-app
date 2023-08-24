using System.ComponentModel.DataAnnotations;

namespace simple_crud_asp_net_core_web_app_razor.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}