using ShareLinkFinal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShareLinkFinal.ViewModels.Users
{
    public class UniqueUrlAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ShareLinkDbContext db = new ShareLinkDbContext();
            string urlValue = value.ToString();
            int count = db.Urls.Where(x => x.URL == urlValue).ToList().Count();
            if (count != 0)
                return new ValidationResult("Url Already Exist");
            return ValidationResult.Success;
        }
    }
       
    [NotMapped]
    public class SubmitUrlViewModel
    {
        [Required]
        public string UrlTitle { get; set; }
        [Required]
        [Url]
        [UniqueUrl]
        public string URL { get; set; }
        [Required]
        public string UrlDesc { get; set; }
        [Required]
        public string Category { get; set; }

    }
}

