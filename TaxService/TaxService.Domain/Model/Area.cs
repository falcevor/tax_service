﻿using System.Collections.Generic;

namespace TaxService.Domain.Model
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Inspector Inspector { get; set; } 
        public IEnumerable<Taxpayer> Taxpayers { get; set; }
    }
}
