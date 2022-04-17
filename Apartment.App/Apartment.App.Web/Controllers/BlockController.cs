using Apartment.App.Business.Abstract;
using Apartment.App.Business.DTO;
using Apartment.App.Web.Models.BlockModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Apartment.App.Web.Controllers
{
    public class BlockController : Controller
    {
        private IBlockService blockService;
        private IFloorService floorService;
        private IMapper mapper;
        public BlockController(IBlockService blockService, IFloorService floorService,IMapper mapper)
        {
            this.blockService = blockService;
            this.floorService = floorService;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = new BlockViewModel();
            var blocks = blockService.GetAll();
            var floors = floorService.GetAll();
            
            foreach (var block in blocks)
            {
                var blockFloor = floorService.GetAllByBlockId(block.Id);
                
                model.Blocks.Add(mapper.Map<BlockDto>(block));
                
            }
            model.Blocks.Sort();
            return View(model);
        }

        
    }
}
