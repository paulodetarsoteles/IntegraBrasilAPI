using AutoMapper;
using IntegraBrasilAPI.API.DTOs;
using IntegraBrasilAPI.Domain.Models;

namespace IntegraBrasilAPI.API.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, Banco>();
            CreateMap<Banco, BancoResponse>();
        }
    }
}
