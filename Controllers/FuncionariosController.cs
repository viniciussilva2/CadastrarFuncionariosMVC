using CadastrarFuncionariosMVC.Interfaces;
using CadastrarFuncionariosMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CadastrarFuncionariosMVC.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly IFuncionariosService _funcionariosService;

        public FuncionariosController(IFuncionariosService funcionariosService)
        {
            _funcionariosService = funcionariosService;
        }

        
        public IActionResult Index()
        {
            var funcionarios = _funcionariosService.ObterFuncionarios();
            return View(funcionarios);
        }



        [HttpPost]
        public IActionResult SalvarFuncionario(FuncionariosViewModel model)
        {
            if (ModelState.IsValid)
            {
                _funcionariosService.Salvar(model);
                TempData["MensagemSucesso"] = "Funcionário salvo com sucesso!";
                return RedirectToAction("Index");
            }
            TempData["MensagemErro"] = "Erro ao salvar o funcionário.";
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult EditarFuncinario(FuncionariosViewModel model)
        {
            if (ModelState.IsValid)
            {
                _funcionariosService.AtualizarFuncionario(model);
                TempData["MensagemSucesso"] = "Funcionário atualizado com sucesso!";
                return RedirectToAction("Index");
            }
            return View(model);
        }


        [HttpPost]
        public IActionResult DelatarFuncionario(int id)
        {
            try
            {
                _funcionariosService.Excluir(id);
                TempData["MensagemSucesso"] = "Funcionário excluído com sucesso!";
            }
            catch
            {
                TempData["MensagemErro"] = "Erro ao excluir o funcionário.";
            }
            return RedirectToAction("Index");
        }
    }
}
