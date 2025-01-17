﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KSResumo.Models
{
    public class New
    {
        public int ID { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Text { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
