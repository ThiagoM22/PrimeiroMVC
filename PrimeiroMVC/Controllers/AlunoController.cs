using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Ryan Rattini Ribeiro", "ryan.rattini@aluno.senai.br", 12345);
            Aluno a2 = new Aluno(2, "Bruno Henrique Martins Alves Junior", "bruno.martins@aluno.senai.br", 696969);
            Aluno a3 = new Aluno(3, "Joaquim Guilherme", "joaquim.guilherme@aluno.senai.br", 112233);
            Aluno a4 = new Aluno(1, "João Rodolfo Jones", "joão.jones@aluno.senai.br", 334455);
            Aluno a5 = new Aluno(1, "Laura Roberta", "laura.roberta@aluno.senai.br", 12345);

            //Criar uma lista de Alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            //Adicionar os Objetos Alunos na lista Alunos
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);
            //Enviando a lista de alunos por paramentro na View Index
            return View(listaAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
