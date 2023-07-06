using Microsoft.AspNetCore.Mvc;
using ZaferTurizm.Business.Services.VehicleMakeManagers;
using ZaferTurizm.DTOs.VehicleMakeAllDtos;
using ZaferTurizm.WebApp.Models;

namespace ZaferTurizm.WebApp.Controllers
{
    public class VehicleMakeController : Controller
    {
        private readonly IVehicleMakeService _vehicleMakeService;

        public VehicleMakeController(IVehicleMakeService vehicleMakeService)
        {
            _vehicleMakeService = vehicleMakeService;
        }

        public IActionResult Index()
        {
            var vehicleMakes = _vehicleMakeService.GetAll();
            return View(vehicleMakes);
        }
        public IActionResult Create() 
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateVehicleMake(MarkaViewModel markaViewModel) 
        
        {
            string vm = markaViewModel.Marka_Adi;
            var vehicleMakeDto = new VehicleMakeDto()
            {
                Name = vm
            };
            var result = _vehicleMakeService.Create(vehicleMakeDto);
            
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Ok();
            }
        }
        
        public IActionResult Update(int id)
        {
            var findedMarka =_vehicleMakeService.GetById(id);
            if (findedMarka != null) 
            { 
                return View(findedMarka); 
            }
            else 
            {
                return NotFound(); 
            }
            
        }
        [HttpPost]
        public IActionResult Update(VehicleMakeDto vehicleMakeDto)
        {
            var result = _vehicleMakeService.Update(vehicleMakeDto);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Ok();        
            }
            
        }
       
        [HttpPost]
        public IActionResult Delete(int id)
        {

            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            var result = _vehicleMakeService.Delete(id);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }


        }
    }
}




        








