using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zooline.Data;
using Zooline.Models;

namespace Zooline.Views.Animales
{
    public class AnimalesController : Controller
    {
        private readonly ApplicationDbContext _dbApplication;
        public AnimalesController(ApplicationDbContext contexto)
        {
            _dbApplication = contexto;
        }
        [Route("[controller]/{id?}")]
        public async Task<IActionResult> Index(string id)
        {
            if (!int.TryParse(id, out var EspecieId))
                return View(new List<AnimalesModels>());

            var especies = await _dbApplication.Especie.Where(x => x.Id == EspecieId).OrderByDescending(x => x.Id).Select(x => new AnimalesModels
            {
                Descripcion = x.descripcion,
                Reino = x.Reino,
                NombreCientifico = x.NombreCientifico,
                Nombre = x.Nombre,

            }).ToListAsync();
            return View(especies);
        }
    }
}
