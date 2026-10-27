
using Microsoft.AspNetCore.Mvc;
using biblioteca.Models;

namespace biblioteca.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            List<Livro> livros = new List<Livro>
            {
                new Livro
                {
                    Id = 1,Titulo = "A Rede dos Mistérios",Autor = "Ana Martins",AnoPublicacao = 2020,Disponivel = true
                },
                new Livro
                {
                    Id = 2,Titulo = "Programar o Futuro",Autor = "Pedro Lopes",AnoPublicacao = 2022,Disponivel = true
                },
                new Livro
                {
                    Id = 3,
                    Titulo = "A Biblioteca Esquecida",Autor = "Sofia Ferreira",AnoPublicacao = 2018,Disponivel = false
                },
                new Livro
                {
                    Id = 4,
                    Titulo = "Viagem ao Mundo Digital",Autor = "João Costa",AnoPublicacao = 2021,Disponivel = true
                },
                new Livro
                {
                    Id = 5, Titulo = "O Meu Primeiro Projeto MVC",Autor = "Marta Rodrigues", AnoPublicacao = 2019, Disponivel = false
                }
            };
            return View(livros);
        }
    }
}
