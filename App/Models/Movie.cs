using App.Data;

namespace App.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCatagory MovieCatagory { get; set; }

        //Relationships
        public List<Actor> Actors { get; set; }

        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
    }
}