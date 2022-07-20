using RCVUCAB.BussinesLogic.Providers.DTOs.DTOs;
using RCVUCAB.BussinesLogic.ProvidersCommands.Commands.Atomics;
using RCVUCAB.BussinesLogic.ProvidersCommands.Commands.Composes;
using RCVUCAB.DataAccess.Provider.Entities;

namespace RCVUCAB.BussinesLogic.ProvidersCommands
{
    public class CommandFactory
    {
        public static GetProvidersByBrandCommand createGetProvidersByBrandCommand(string brand)
        {
            return new GetProvidersByBrandCommand(brand);
        }

        public static CreateProviderQuotationCommand createCreateProviderQuotationCommand(QuotationEntity quotation)
        {
            return new CreateProviderQuotationCommand(quotation);
        }

        public static InsertProviderQuotationCommand createInsertProviderQuotationCommand(QuotationEntity quotation)
        {
            return new InsertProviderQuotationCommand(quotation);
        }

        public static SendProviderQuotationCommand createSendProviderQuotationCommand(QuotationDTO quotation)
        {
            return new SendProviderQuotationCommand(quotation);
        }
    }
}