using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App4.Services;
using Microsoft.AspNetCore.Mvc;

namespace App4.Controllers
{
    
    public class DiseasesController : Controller
    {
        private readonly DiseaseService _diseaseService;

        public DiseasesController(DiseaseService diseaseService)
        {
            _diseaseService = diseaseService;
        }

        public IActionResult Index()
        {
          
            return View(_diseaseService.List());
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            try
            {
                _diseaseService.remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception) 
            {
                //adicionar tela de error personalizada 
                return RedirectToAction(nameof(Index));
            }
        }
    }
}