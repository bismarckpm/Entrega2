using RCVUCAB.BussinesLogic.Providers.DTOs.DTOs;
using RCVUCAB.DataAccess.Provider;
using RCVUCAB.DataAccess.Provider.DAOs.DB;

namespace RCVUCAB.BussinesLogic.ProvidersCommands.Commands.Atomics
{
    public class GetProvidersByBrandCommand : Command<BrandDTO>
    {
        private readonly string _brand;
        private BrandDTO _result;

        public GetProvidersByBrandCommand(string brand)
        {
            _brand = brand;
        }


        public override void Execute()
        {
            ProviderDB dao = ProviderDAOFactory.CreateProviderDB();
            _result = dao.GetProvidersByBrand(_brand);
        }

        public override BrandDTO GetResult()
        {
            return _result;
        }
    }
}
