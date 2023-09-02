using E_Ticket.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_Ticket.Data.Base;

namespace E_Ticket.Models
{
    //public class Movie
    //{
    //    //Tabel Primary Key
    //    [Key]
    //    public int Id { get; set; }
    //    [Required]

    //    //Movie Name
    //    public string Name { get; set; }

    //    //Description of the Moviue
    //    public string Description { get; set; }

    //    //Movie Price
    //    public double Price { get; set; }

    //    //Picture Of Movie
    //    public string ImageURL { get; set; }

    //    //The Movie Start Date
    //    public DateTime StartDate { get; set; }

    //    //The Movie End Date
    //    public DateTime EndDate { get; set; }

    //    //Movie Category
    //    public MovieCategory MovieCategory { get; set; }

    //    //Relationships
    //    public List<Actor_Movie> Actor_Movies { get; set; }

    //    //Cinema
    //    public int CinemaId { get; set; }
    //    [ForeignKey("CinemaId")]
    //    public Cinema Cinema { get; set; }

    //    //Producer  
    //    public int ProducerId { get; set; }
    //    [ForeignKey("ProducerId")]
    //    public Producer Producer { get; set; }
    //}


    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
