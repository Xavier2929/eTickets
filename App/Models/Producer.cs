using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Producer
    {
        [Key] //this is part of the data annotations library
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string Fullname { get; set; }
        public string Biography { get; set; }

        //relationships

        public List<Movie> Movies { get; set; }
    }
}