﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MrVeggie.Models.Pages {


    public class NewReceita {
        public Receita receita { get; set; }
        public List<Utensilio> utensilios { get; set; }     
    }
}
