using AutoMapper;
using FlowerShop.BLL.DTOs;
using FlowerShop.BLL.IServices;
using FlowerShop.DLL.DataModels;
using FlowerShop.DLL.IRepository;

namespace FlowerShop.BLL.Services
{
    public class FlowerService :IFlowerService
    {
        private readonly IFlowerRepository _flowerRepository;
        private readonly IMapper _mapper;

        public FlowerService(IFlowerRepository flowerRepository, IMapper mapper)
        {
            _flowerRepository = flowerRepository;
            _mapper = mapper;
        }

        public List<FlowerDTO> GetAllFlowers()
        {
            return _mapper.Map<List<FlowerDTO>>(_flowerRepository.GetAllFlowers());
        }

        public FlowerDTO GetFlowerById(int id)
        {
            return _mapper.Map<FlowerDTO>(_flowerRepository.GetFlowerById(id));
        }

        public void AddFlower(FlowerDTO flower)
        {
            var newFlower = _mapper.Map<Flower>(flower);
            newFlower.CreatedDate = DateTime.Now;
            _flowerRepository.AddFlower(newFlower);
        }

        public void UpdateFlower(int id, FlowerDTO flower)
        {
            var newFlower = _mapper.Map<Flower>(flower);
            newFlower.Id = id;
            newFlower.ModifiedDate = DateTime.Now;
           _flowerRepository.UpdateFlower(newFlower);
        }

        public void DeleteFlower(int id)
        {
            var flower=_flowerRepository.GetFlowerById(id);
            flower.IsDeleted = true;
            flower.ModifiedDate = DateTime.Now;
            _flowerRepository.UpdateFlower(flower);
        }
    }
}
