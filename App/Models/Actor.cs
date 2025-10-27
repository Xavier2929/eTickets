using System.ComponentModel.DataAnnotations;
using System.Data;

namespace App.Models
{
    public class Actor
    {
        [Key] //this is part of the data annotations library
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string Fullname { get; set; }
        public string Biography { get; set; }

        //relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}