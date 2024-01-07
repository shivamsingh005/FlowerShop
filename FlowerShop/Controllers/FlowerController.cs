using FlowerShop.BLL.DTOs;
using FlowerShop.BLL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers
{
    public class FlowerController : Controller
    {
        private readonly IFlowerService _flowerService;

        public FlowerController(IFlowerService flowerService)
        {
            _flowerService = flowerService;
        }

        public ActionResult Index()
        {
            var data = _flowerService.GetAllFlowers();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public void CreateFlower(FlowerDTO flower)
        {
            if (flower != null)
            {
                _flowerService.AddFlower(flower);
            }
        }

        [HttpPost]
        public void UpdateFlower(int id, FlowerDTO flower)
        {
            try
            {
                _flowerService.UpdateFlower(id, flower);
            }
            catch(Exception e){}
        }

        public void Delete(int id)
        {
            _flowerService.DeleteFlower(id);
        }
    }
}
