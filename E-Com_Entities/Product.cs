﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com_Entities
{
    public class Product:BaseEntity
    {
        public decimal Price { get; set; }

        public Category category { get; set; }
    }
}
