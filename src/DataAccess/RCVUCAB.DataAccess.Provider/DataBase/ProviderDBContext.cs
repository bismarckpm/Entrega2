using Microsoft.EntityFrameworkCore;
using RCVUCAB.DataAccess.Provider.Entities;


namespace RCVUCAB.DataAccess.Provider.DataBase
{
    public class ProviderDBContext : DbContext, IProviderDBContext
    {

        public ProviderDBContext(DbContextOptions<ProviderDBContext> options)
            : base(options)
        {
        }

        public DbContext DbContext
        {
            get
            {
                return this;
            }
        }

        public virtual DbSet<ProviderEntity> Providers
        {
            get; set;
        }

        public virtual DbSet<BrandEntity> Brands
        {
            get;
            set;
        }

        public virtual DbSet<QuotationEntity> Quotation
        {
            get; set;
        }

        public virtual DbSet<QuotationDetailEntity> QuotationDetail
        {
            get;
            set;
        }

    }
}