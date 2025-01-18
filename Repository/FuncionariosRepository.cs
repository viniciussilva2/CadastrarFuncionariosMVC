using CadastrarFuncionariosMVC.Context;
using CadastrarFuncionariosMVC.Entities;
using CadastrarFuncionariosMVC.Interfaces;
using CadastrarFuncionariosMVC.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace CadastrarFuncionariosMVC.Repository
{
    public class FuncionariosRepository : IFuncionariosRepository
    {
        private readonly AppDbContext _context;

        public FuncionariosRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Salvar(FuncionariosViewModel model)
        {
            var funcionario = new Funcionarios
            {
                Nome = model.Nome,
                Idade = model.Idade,
                Email = model.Email,
                Cargo = model.Cargo
            };

            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
        }

        public void AtualizarFuncionario(FuncionariosViewModel model)
        {
            var funcionario = _context.Funcionarios.Find(model.Id);
            if (funcionario != null)
            {
                funcionario.Nome = model.Nome;
                funcionario.Idade = model.Idade;
                funcionario.Email = model.Email;
                funcionario.Cargo = model.Cargo;

                _context.Funcionarios.Update(funcionario);
                _context.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);
            if (funcionario != null)
            {
                _context.Funcionarios.Remove(funcionario);
                _context.SaveChanges();
            }
        }

        public IEnumerable<FuncionariosViewModel> ObterFuncionarios()
        {
            return _context.Funcionarios.Select(f => new FuncionariosViewModel
            {
                Id = f.Id,
                Nome = f.Nome,
                Idade = f.Idade,
                Email = f.Email,
                Cargo = f.Cargo
            }).ToList();
        }

        public FuncionariosViewModel ObterFuncionarioPorId(int id)
        {
            var funcionario = _context.Funcionarios.Find(id);
            if (funcionario != null)
            {
                return new FuncionariosViewModel
                {
                    Id = funcionario.Id,
                    Nome = funcionario.Nome,
                    Idade = funcionario.Idade,
                    Email = funcionario.Email,
                    Cargo = funcionario.Cargo
                };
            }
            return null;
        }
    }
}
