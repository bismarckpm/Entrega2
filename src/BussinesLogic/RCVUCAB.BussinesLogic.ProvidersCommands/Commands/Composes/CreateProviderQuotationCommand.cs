using RCVUCAB.BussinesLogic.Providers.DTOs.DTOs;
using RCVUCAB.BussinesLogic.ProvidersCommands.Commands.Atomics;
using RCVUCAB.DataAccess.Provider.Entities;

namespace RCVUCAB.BussinesLogic.ProvidersCommands.Commands.Composes
{
    public class CreateProviderQuotationCommand : Command<QuotationDTO>
    {
        private readonly QuotationEntity _quotation;
        private QuotationDTO _result;

        public CreateProviderQuotationCommand(QuotationEntity quotation)
        {
            _quotation = quotation;
        }


        public override void Execute()
        {
            InsertProviderQuotationCommand commandInsert = CommandFactory.createInsertProviderQuotationCommand(_quotation);
            commandInsert.Execute();
            _result = commandInsert.GetResult();
            SendProviderQuotationCommand commandSend = CommandFactory.createSendProviderQuotationCommand(_result);
            commandSend.Execute();
        }

        public override QuotationDTO GetResult()
        {
            return _result;
        }
    }
}
