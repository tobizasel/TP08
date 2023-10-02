using Microsoft.AspNetCore.Mvc;

namespace TP08.Controllers;

public class Account : Controller
{
    public IActionResult Index()
    {
        return View();
    }

        public IActionResult registro()
    {
        return View();
    }

        public IActionResult CrearCuenta(Usuarios usuario)
    {
        Console.WriteLine(usuario.Username + "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        BD.crearCuenta(usuario);
        return View("bienvenida");
    }

    public IActionResult login(Usuarios usuario)
    {
        if (BD.validar(usuario))
        {
            return RedirectToAction("bienvenida");
        } else return RedirectToAction("registro");
    }
}
