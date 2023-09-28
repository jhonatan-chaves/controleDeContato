using Microsoft.AspNetCore.Mvc;

namespace ControleDeContato.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
