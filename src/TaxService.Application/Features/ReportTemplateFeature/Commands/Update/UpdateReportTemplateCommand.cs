﻿using MediatR;
using System.Collections.Generic;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.ReportTemplateFeature.Commands.Update
{
    public class UpdateReportTemplateCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public IList<ReportTemplateParameter> Parameters { get; set; }
    }
}
