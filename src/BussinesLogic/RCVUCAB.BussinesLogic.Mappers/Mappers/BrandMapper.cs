
using RCVUCAB.BussinesLogic.Providers.DTOs.DTOs;
using RCVUCAB.DataAccess.Provider.Entities;

namespace RCVUCAB.BussinesLogic.Providers.Mappers
{
    public class BrandMapper
    {
        public static BrandDTO MapEntityToDto(BrandEntity entity)
        {
            var quotation = new BrandDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                Providers = ProviderMapper.MapListEntityToListDto(entity.Providers)
            };
            return quotation;
        }
    }
}
