using AutoMapper;
using Magma3_Back.Entities;
using Magma3_Back.ViewModels;

namespace Magma3_Back.Mappers
{
    public class NotaMapper : Profile
    {
        public NotaMapper()
        {
            CreateMap<Nota, NotaViewModel>();
            CreateMap<NotaViewModel, Nota>();
        }
    }
}
