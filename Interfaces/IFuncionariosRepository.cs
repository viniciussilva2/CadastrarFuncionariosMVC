using CadastrarFuncionariosMVC.ViewModels;
using System.Collections.Generic;

namespace CadastrarFuncionariosMVC.Interfaces
{
    public interface IFuncionariosRepository
    {
        void Salvar(FuncionariosViewModel model);

        void AtualizarFuncionario(FuncionariosViewModel model);

        void Excluir(int id);

        IEnumerable<FuncionariosViewModel> ObterFuncionarios();

        FuncionariosViewModel ObterFuncionarioPorId(int id);
    }
}
