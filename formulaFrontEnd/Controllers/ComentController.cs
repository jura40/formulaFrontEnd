using formulaFrontEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formulaFrontEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComentController : Controller
    {
        [HttpGet("create/{id}")]
        public IActionResult Create(int id)
        {
            var coment = new Coment
            {
                driverId = id,
                createdAt = DateTime.Now
            };

            return View(coment);
        }

        [HttpPost("createcoment")]
        public async Task<IActionResult> CreateComent([FromForm] Coment coment)
        {
            
            return RedirectToAction("Coment", "Driver", coment.driverId);
        }
    }
}
