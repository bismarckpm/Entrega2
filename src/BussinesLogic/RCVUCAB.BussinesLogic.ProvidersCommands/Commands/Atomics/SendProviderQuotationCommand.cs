using RCVUCAB.BussinesLogic.Providers.DTOs.DTOs;
using RCVUCAB.DataAccess.Provider;
using RCVUCAB.DataAccess.Provider.DAOs.MQ;


namespace RCVUCAB.BussinesLogic.ProvidersCommands.Commands.Atomics
{
    public class SendProviderQuotationCommand : Command<int>
    {
        private readonly QuotationDTO _quotation;
        public SendProviderQuotationCommand(QuotationDTO quotation)
        {
            _quotation = quotation;
        }

        public override void Execute()
        {
            ProviderMQ dao = ProviderDAOFactory.CreateProviderMQ();
            dao.Producer(_quotation);
        }

        public override int GetResult()
        {
            throw new NotImplementedException();
        }
    }
}
