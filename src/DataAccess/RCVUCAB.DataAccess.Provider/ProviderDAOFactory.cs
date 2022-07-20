using RCVUCAB.DataAccess.Provider.DAOs.DB;
using RCVUCAB.DataAccess.Provider.DAOs.MQ;

namespace RCVUCAB.DataAccess.Provider
{
    public class ProviderDAOFactory
    {
        public static ProviderDB CreateProviderDB()
        {
            return new ProviderDB();
        }

        public static ProviderMQ CreateProviderMQ()
        {
            return new ProviderMQ();
        }
    }
}
