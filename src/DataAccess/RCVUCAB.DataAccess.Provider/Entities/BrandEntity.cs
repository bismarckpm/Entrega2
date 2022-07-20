using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCVUCAB.DataAccess.Provider.Entities
{
    public class BrandEntity : BaseEntity
    {
        public string? Name { get; set; }
        public string? Country { get; set; }
        public ICollection<ProviderEntity>? Providers { get; set; }
    }
}
