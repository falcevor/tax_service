﻿using System.Collections.Generic;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.ReportTemplateFeature.Queries.GetAll
{
    public class GetReportTemplatesResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public IEnumerable<ReportTemplateParameter> Parameters { get; set; }
    }
}
