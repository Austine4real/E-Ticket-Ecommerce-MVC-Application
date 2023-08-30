using E_Ticket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace E_Ticket.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; } 
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "FullName is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Full Name must be btween 3 and 50 Chars")]

        public string FullName { get; set; } 
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Bio is required")]
        public string Bio { get; set; } 

        //Relationship
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
