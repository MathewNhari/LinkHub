﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareLinkFinal.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public List<Url> Urls { get; set; }
    }
}
