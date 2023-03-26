using ShringarWorld.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ShringarWorld.Models
{
    public class Earings
    {
        [Key]

        public int Id { get; set; }
        public string? ProfilePicture { get; set; }
        public string? Bio { get; set; }

        public int ProductCode {get;set;}

        public String? Price { get; set; }

        public EaringCategory EaringCategory { get; set; }
    }
}
