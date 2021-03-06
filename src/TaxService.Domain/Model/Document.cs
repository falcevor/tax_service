﻿namespace TaxService.Domain.Model
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public int TaxpayerId { get; set; }
        public Taxpayer Taxpayer { get; set; }
    }
}
