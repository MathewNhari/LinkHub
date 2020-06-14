using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShareLinkFinal.Models
{
    public class Url
    {
        [Key]
        public int UrlId { get; set; }
        [Required]
        public string UrlTitle { get; set; }
        [Required]
        [Url]
        public string URL { get; set; }
        [Required]
        public string UrlDesc { get; set; }
        [Required]
        public string IsApproved { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Category Category { get; set; }
    }
}
