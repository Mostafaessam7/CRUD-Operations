using CRUD_Operations_In_ASP.Net_5__Core_MVC_.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Operations_In_ASP.Net_5__Core_MVC_.ViewModels
{
    public class MovieFormVM
    {
        public int Id { get; set; }
        [Required,StringLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
        [Range(1,10)]
        public double Rate { get; set; }
        [Required, StringLength(2500)]

        public string StoryLine { get; set; }
        [Display(Name = "Select Poster..")]

        public byte[] Poster { get; set; }
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}
