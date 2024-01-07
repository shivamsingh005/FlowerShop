using FlowerShop.DLL.DataModels;
using FlowerShop.DLL.IRepository;

namespace FlowerShop.DLL.Repository
{
    public class FlowerRepository : IFlowerRepository
    {
        private readonly FlowerShopManagementContext _context;

        public FlowerRepository(FlowerShopManagementContext context)
        {
            _context = context;
        }

        public List<Flower> GetAllFlowers()
        {
            return _context.Flowers.Where(x => (bool)!x.IsDeleted).ToList();
        }

        public Flower GetFlowerById(int id)
        {
            return _context.Flowers.FirstOrDefault(x => x.Id.Equals(id) && (bool)!x.IsDeleted) ?? new();
        }

        public void AddFlower(Flower flower)
        {
            _context.Add(flower);
            _context.SaveChanges();
        }

        public void UpdateFlower(Flower flower)
        {
            _context.Update(flower);
            _context.SaveChanges();
        }
    }
}
