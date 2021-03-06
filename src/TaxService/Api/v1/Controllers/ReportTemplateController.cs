﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Create;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Delete;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Update;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetAll;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetById;

namespace TaxService.Api.v1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class ReportTemplateController : ControllerBase
    {
        private readonly IMediator _bus;

        public ReportTemplateController(IMediator bus)
        {
            _bus = bus;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetReportTemplatesResponse>>> GetReportTempalates()
        {
            var result = await _bus.Send(new GetReportTemplatesQuery());
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<GetReportTemplateByIdResponse>> GetReportTemplate(int id)
        {
            var result = await _bus.Send(new GetReportTemplateByIdQuery() { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> CreateReportTemplate(CreateReportTemplateCommand command)
        {
            await _bus.Send(command);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateReportTemplate(UpdateReportTemplateCommand command)
        {
            await _bus.Send(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteReportTemplate(int id)
        {
            await _bus.Send(new DeleteReportTemplateCommand() { Id = id });
            return Ok();
        }
    }
}
