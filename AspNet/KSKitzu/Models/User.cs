﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Models
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }

    }
}
