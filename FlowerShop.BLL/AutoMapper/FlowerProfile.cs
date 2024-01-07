using AutoMapper;
using FlowerShop.BLL.DTOs;
using FlowerShop.DLL.DataModels;

namespace FlowerShop.BLL.AutoMapper
{
    public class FlowerProfile : Profile
    {
        public FlowerProfile()
        {
            CreateMap<Flower, FlowerDTO>().ReverseMap();
        }
    }
}
