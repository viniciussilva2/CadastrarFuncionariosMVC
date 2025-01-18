using Microsoft.AspNetCore.Mvc;

namespace CadastrarFuncionariosMVC.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
