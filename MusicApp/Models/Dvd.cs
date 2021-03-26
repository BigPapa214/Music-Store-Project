using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class Dvd
    { 
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        public int Catergory { get; set; }
        public DateTime Age { get; set; }
    }
}
