﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroDomain.Models
{
   public class SuperPower
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Description { get; set; }
        public int? OwnerId { get; set; }
    }
}
