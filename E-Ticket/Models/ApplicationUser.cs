using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Ticket.Models
{
	public class ApplicationUser : IdentityUser
	{
		[Display(Name = "Full Name")]
		public string FullName { get; set; }
	}
}
