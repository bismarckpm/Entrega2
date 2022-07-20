using RCVUCAB.BussinesLogic.Providers.DTOs.DTOs;
using RCVUCAB.DataAccess.Provider;
using RCVUCAB.DataAccess.Provider.DAOs.DB;
using RCVUCAB.DataAccess.Provider.Entities;


namespace RCVUCAB.BussinesLogic.ProvidersCommands.Commands.Atomics
{
    public class InsertProviderQuotationCommand : Command<QuotationDTO>
    {
        private readonly QuotationEntity _quotation;
        private QuotationDTO _result;

        public InsertProviderQuotationCommand(QuotationEntity quotation)
        {
            _quotation = quotation;
        }


        public override void Execute()
        {
            ProviderDB dao = ProviderDAOFactory.CreateProviderDB();
            _result = dao.CreateProviderQuotation(_quotation);
        }

        public override QuotationDTO GetResult()
        {
            return _result;
        }
    }
}
