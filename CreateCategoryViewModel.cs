using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShareLinkFinal.ViewModels.Admin
{
    [NotMapped]
    public class CreateCategoryViewModel
    {
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string CategoryDesc { get; set; }
    }
}
