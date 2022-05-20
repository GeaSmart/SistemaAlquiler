using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.DTO;
using Windows.Entities;

namespace Windows.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClienteEntity, ClienteDTO>()
                .ForMember(dest => dest.DocumentoNombreCompleto, opt => opt.MapFrom(src => $"{src.Documento} - {src.NombreCompleto}"))
                .ReverseMap();
        }
    }
}
