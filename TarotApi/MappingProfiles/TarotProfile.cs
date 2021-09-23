using AutoMapper;
using TarotApi.Domain.Models;
using TarotApi.ViewModels;

namespace TarotApi.MappingProfiles
{
    public class TarotProfile : Profile
    {
        public TarotProfile()
        {
            CreateMap<CardViewModel, Card>()
                .ReverseMap();

            CreateMap<Draw, DrawViewModel>()
                .ReverseMap();
        }
    }
}
