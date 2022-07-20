using Microsoft.EntityFrameworkCore;
using RCVUCAB.DataAccess.Provider.Entities;


namespace RCVUCAB.DataAccess.Provider.DataBase
{
    public interface IProviderDBContext
    {
        DbContext DbContext
        {
            get;
        }


        DbSet<ProviderEntity> Providers
        {
            get; set;
        }

        DbSet<BrandEntity> Brands
        {
            get; set;
        }

        DbSet<QuotationEntity> Quotation
        {
            get; set;
        }

        DbSet<QuotationDetailEntity> QuotationDetail
        {
            get; set;
        }
    }
}
