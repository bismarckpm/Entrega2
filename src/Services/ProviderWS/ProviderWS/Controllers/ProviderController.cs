using Microsoft.AspNetCore.Mvc;
using RCVUCAB.BussinesLogic.Providers.DTOs.DTOs;
using RCVUCAB.BussinesLogic.Providers.Mappers;
using RCVUCAB.BussinesLogic.ProvidersCommands;
using RCVUCAB.BussinesLogic.ProvidersCommands.Commands.Atomics;
using RCVUCAB.BussinesLogic.ProvidersCommands.Commands.Composes;
using System.ComponentModel.DataAnnotations;

namespace ProviderWS.Controllers
{
    [ApiController]
    [Route("provider")]
    public class ProviderController : Controller
    {
        private readonly ILogger<ProviderController> _logger;

        public ProviderController(ILogger<ProviderController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{brand}")]
        public BrandDTO GetProvidersByBrand([Required][FromRoute] string brand)
        {
            try
            {
                GetProvidersByBrandCommand command =
                  CommandFactory.createGetProvidersByBrandCommand(brand);
                command.Execute();
                return command.GetResult();
            }
            catch (Exception )
            {
                throw;
            }
        }


        [HttpPost("quotation")]
        public QuotationDTO CreateClaimAuctionQuotation([FromBody] QuotationDTO request)
        {
            try
            {
                var quotation = QuotationMapper.MapDtoToEntity(request);
                CreateProviderQuotationCommand command =
                  CommandFactory.createCreateProviderQuotationCommand(quotation);
                command.Execute();
                return command.GetResult();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
