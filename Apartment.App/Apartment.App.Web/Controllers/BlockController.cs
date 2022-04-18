using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Apartment.App.Business.Abstract;
using Apartment.App.Business.DTO;
using Apartment.App.Domain.Entities;
using Apartment.App.Web.Models.BlockModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Apartment.App.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BlockController : Controller
    {
        private IBlockService blockService;
        private IFloorService floorService;
        private IHousingService housingService;
        private IMapper mapper;
        public BlockController(IBlockService blockService, IFloorService floorService, IHousingService housingService, IMapper mapper)
        {
            this.blockService = blockService;
            this.floorService = floorService;
            this.housingService = housingService;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = new BlockViewModel();

            var blocks = blockService.GetAll();
            foreach (var block in blocks)
            {
                var floors = floorService.GetAllByBlockId(block.Id);
                var floorDtos = new List<FloorDto>();
                foreach (var floor in floors)
                {
                    var floorInBlock = mapper.Map<FloorDto>(floor);
                    floorInBlock.HousingCount = housingService.GetHousingCountByFloorId(floor.Id);
                    floorDtos.Add(floorInBlock);
                }
                var blockModel = new BlockModel
                {
                    block = mapper.Map<BlockDto>(block),
                    floorsInBlokcs = floorDtos
                };
                blockModel.blockHasHirer = blockHasHirerCheck(block.Id);
                model.Blocks.Add(blockModel);
            }
            
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            //MANUEL OLARAK İSİM VE NUMARA VERİLİYOR
            var blocks = blockService.GetAll().OrderByDescending(b => b.Id).First();
            var newBlock = new BlockDto();
            if (blocks != null)
            {
                newBlock.BlockNumber = blocks.BlockNumber + 1;
            }
            blockService.Add(mapper.Map<Block>(newBlock));

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id != null && id > 0)
            {
                var block = blockService.GetById(id);
                var floors = floorService.GetAllByBlockId(id);
                var housings = housingService.GetHousingByBlockId(id);
                foreach (var housing in housings)
                {
                    housingService.Delete(housing);
                }

                foreach (var floor in floors)
                {
                   floorService.Delete(floor); 
                }
                blockService.Delete(block);
            }
            return RedirectToAction("Index");
        }
        private bool blockHasHirerCheck(int blockId)
        {
             return  housingService.GetHousingByBlockId(blockId).Where(h => h.IsEmpty == false).Any();
        }
    }


}
