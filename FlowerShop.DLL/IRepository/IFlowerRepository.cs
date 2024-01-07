using FlowerShop.DLL.DataModels;

namespace FlowerShop.DLL.IRepository
{
    public interface IFlowerRepository
    {
        List<Flower> GetAllFlowers();

        Flower GetFlowerById(int id);

        void AddFlower(Flower flower);

        void UpdateFlower(Flower flower);
    }
}
