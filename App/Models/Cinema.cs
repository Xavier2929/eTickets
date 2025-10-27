using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Cinema
    {
        [Key] //this is part of the data annotations library
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}