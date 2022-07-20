namespace RCVUCAB.BussinesLogic.Providers.DTOs.DTOs
{
    public class BrandDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<ProviderDTO>? Providers { get; set; }
    }
}
