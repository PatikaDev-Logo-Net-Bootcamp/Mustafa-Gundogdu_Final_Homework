using Apartment.App.Business.Abstract;
using Apartment.App.Business.DTO;
using Apartment.App.Web.Models.FloorModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    public class FloorController : Controller
    {
        private IFloorService floorsService;
        private IBlockService blockService;
        private IMapper mapper;
        public FloorController(IFloorService floorservice, IBlockService blokService, IMapper mapper)
        {
            this.floorsService = floorservice;
            this.blockService = blokService;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = new FloorViewModel();
            var floors = floorsService.GetAll();
            foreach (var floor in floors)
            {
                model.Floors.Add(mapper.Map<FloorDto>(floor));
            }
            model.Floors.Sort((dto, floorDto) => dto.block.BlockNumber);
            return View(model);
        }
        
    }
}
