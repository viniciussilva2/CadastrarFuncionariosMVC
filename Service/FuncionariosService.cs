using CadastrarFuncionariosMVC.Interfaces;
using CadastrarFuncionariosMVC.ViewModels;

namespace CadastrarFuncionariosMVC.Service
{
    public class FuncionariosService : IFuncionariosService
    {
        private readonly IFuncionariosRepository _funcionariosRepository;

        public FuncionariosService(IFuncionariosRepository funcionariosRepository)
        {
            _funcionariosRepository = funcionariosRepository;
        }

        public void Salvar(FuncionariosViewModel model)
        {
            _funcionariosRepository.Salvar(model);
        }

        public void AtualizarFuncionario(FuncionariosViewModel model)
        {
            _funcionariosRepository.AtualizarFuncionario(model);
        }

        public void Excluir(int id)
        {
            _funcionariosRepository.Excluir(id);
        }

        public IEnumerable<FuncionariosViewModel> ObterFuncionarios()
        {
            return _funcionariosRepository.ObterFuncionarios();
        }

        public FuncionariosViewModel ObterFuncionarioPorId(int id)
        {
            return _funcionariosRepository.ObterFuncionarioPorId(id);
        }
    }
}
