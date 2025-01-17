﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class About
    {
        public int ID { get; set; }


        [StringLength(50)]
        public string Title { get; set; }


        [StringLength(200)]
        public string Text { get; set; }
        

        [StringLength(70)]
        public string List { get; set; }


        [StringLength(90)]
        public string Subheading { get; set; }


        public string Image1 { get; set; }
        public string Image2 { get; set; }

        [NotMapped]
        public IFormFile Photo1 { get; set; }
        [NotMapped]
        public IFormFile Photo2 { get; set; }
    }
}
