using FlowerShop.BLL.DTOs;

namespace FlowerShop.BLL.IServices
{
    public interface IFlowerService
    {
        List<FlowerDTO> GetAllFlowers();

        FlowerDTO GetFlowerById(int id);

        void AddFlower(FlowerDTO flower);

        void UpdateFlower(int id, FlowerDTO flower);

        void DeleteFlower(int id);
    }
}
