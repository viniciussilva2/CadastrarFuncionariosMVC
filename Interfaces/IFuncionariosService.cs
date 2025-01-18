using CadastrarFuncionariosMVC.ViewModels;
using System.Collections.Generic;

namespace CadastrarFuncionariosMVC.Interfaces
{
    public interface IFuncionariosService
    {
        void Salvar(FuncionariosViewModel model);

        void AtualizarFuncionario(FuncionariosViewModel model);

        void Excluir(int id);

        IEnumerable<FuncionariosViewModel> ObterFuncionarios();

        FuncionariosViewModel ObterFuncionarioPorId(int id);
    }
}
