using Microsoft.AspNetCore.Mvc;

public class Account : Controller
{
    public IActionResult CrearCuenta(Usuarios usuario)
    {
        BD.crearCuenta(usuario);
        return View();
    }
}
