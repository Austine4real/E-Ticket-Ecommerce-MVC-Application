using E_Ticket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace E_Ticket.Models
{
    public class Producer: IEntityBase
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; } = string.Empty;
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;
        [Display(Name = "Bio")]
        public string Bio { get; set; } = string.Empty;

        //One-to-many Relationship 
        public List<Movie> Movies { get; set; } 
    }
}
