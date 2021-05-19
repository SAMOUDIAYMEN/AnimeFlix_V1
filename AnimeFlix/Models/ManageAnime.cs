using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AnimeFlix.Models
{
    public class ManageAnime
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string titleAnime { get; set; }
        [Required]
        public string src { get; set; }
        [Required]
        public string studion { get; set; }
        [Required]
        public string author { get; set; }
        [Required]
        public string descriptionAnime { get; set; }
        [Required]
        public int ratingAnime { get; set; }
        [Required]
        public string imgAnime { get; set; }
        [Required]
        public string trailerAnime { get; set; }
        [Required]
        public string runtime { get; set; }
        [Required]
        public int categoryAnime { get; set; }
    }
}
