using AutoMapper;
using IntegraBrasilAPI.API.DTOs;
using IntegraBrasilAPI.Domain.Models;

namespace IntegraBrasilAPI.API.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, Endereco>();
            CreateMap<Endereco, EnderecoResponse>();
        }
    }
}
