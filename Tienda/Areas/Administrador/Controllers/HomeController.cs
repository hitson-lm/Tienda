using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Areas.Administrador.Controllers
{   // decimos que el controlador pertenece a la Area Admistrador. Asignando el atributo "Administrador"
    [Area("Administrador")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pedidos()
        {
            return View();
        }

        public IActionResult Productos()
        {
            return View();
        }

        public IActionResult CerrarSesion()
        {
            return View();
        }
    }
}
