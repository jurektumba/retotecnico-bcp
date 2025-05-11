using AutoMapper;
using retotecnico_bcp.Model;
using retotecnico_bcp.Response;

namespace retotecnico_bcp.Mapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TipoCambio, TipoCambioResponse>()
                .ForMember(dest => dest.dcTipoCambio, opt => opt.MapFrom(src => src.dcTipoCambio))
                .ForMember(dest => dest.monedaDestino, opt => opt.MapFrom(src => src.monedaDestino.descripcion))
                .ForMember(dest => dest.monedaOrigen, opt => opt.MapFrom(src => src.monedaOrigen.descripcion));
        }
    }
}
